using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
using System.Linq;
using SmartPoint.AssetAssistant;

namespace SmartPoint.Components
{
    public class AudioPlayer
    {
        private static Dictionary<string, AudioClip> _clipTable = new Dictionary<string, AudioClip>(StringComparer.CurrentCultureIgnoreCase);
        private static List<AudioChannel> _streamChannels = new List<AudioChannel>();
        private static List<AudioChannel> _effectChannels = new List<AudioChannel>();
        private static List<List<AudioChannel>> channelList;
        private static AudioChannel[] _voiceChannels = new AudioChannel[4];
        private static AudioListener _audioListener = null;
        private static AudioListener _currentAudioListener = null;
        private static float _globalStreamVolume = 1.0f;
        private static float _globalEffectVolume = 1.0f;
        private static float _globalVoiceVolume = 1.0f;
        private static Dictionary<string, AudioListener> _listenerTables = new Dictionary<string, AudioListener>();

        public static void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
            GameObject[] rootGameObjects = scene.GetRootGameObjects();

            foreach (var rootGameObject in rootGameObjects)
            {
                var audioListeners = rootGameObject.GetComponentsInChildren<AudioListener>();
                foreach (var audioListener in audioListeners)
                {
                    if (audioListener.enabled)
                    {
                        string scenePath = scene.path;
                        if (_listenerTables.ContainsKey(scenePath))
                        {
                            _listenerTables[scenePath] = audioListener;
                        }
                        else
                        {
                            _listenerTables.Add(scenePath, audioListener);
                        }
                        audioListener.enabled = false;
                    }
                }
            }

            if (_currentAudioListener != null)
            {
                Scene currentAudioListenerScene = _currentAudioListener.gameObject.scene;
                if (currentAudioListenerScene == scene)
                {
                    _currentAudioListener = _audioListener;
                }
            }
        }

        public static void Initialize()
        {
            return;
        }

        public static void OnBeforeSceneChanged(SceneEntity currentScene, SceneEntity targetScene)
        {
            AudioListener targetSceneAudioListener = null;
            string targetScenePath = targetScene.Path; // Assuming SceneEntity has a Path property

            if (_listenerTables.TryGetValue(targetScenePath, out targetSceneAudioListener))
            {
                if (_currentAudioListener != null)
                {
                    _currentAudioListener.enabled = false;
                }

                targetSceneAudioListener.enabled = true;
                _currentAudioListener = targetSceneAudioListener;
            }
            else
            {
                if (_currentAudioListener != _audioListener && _currentAudioListener != null)
                {
                    _currentAudioListener.enabled = false;
                    _currentAudioListener = _audioListener;

                    if (_currentAudioListener != null)
                    {
                        _currentAudioListener.enabled = true;
                    }
                }
            }
        }

        public static float GlobalStreamVolume
        {
            get
            {
                return _globalStreamVolume;
            }
            set
            {
                _globalStreamVolume = value;
                foreach (var channel in _streamChannels)
                {
                    channel.ResetVolume();
                }
            }
        }

        public static float GlobalEffectVolume
        {
            get
            {
                return _globalEffectVolume;
            }
            set
            {
                _globalEffectVolume = value;
                foreach (var channel in _effectChannels)
                {
                    channel.ResetVolume();
                }
            }
        }

        public static float GlobalVoiceVolume
        {
            get
            {
                return _globalVoiceVolume;
            }
            set
            {
                _globalVoiceVolume = value;
                foreach (var channel in _voiceChannels)
                {
                    channel.ResetVolume();
                }
            }
        }

        public static bool IsExistReservation(List<AudioChannel> channels, AudioClip clip)
        {
            foreach (var channel in channels)
            {
                if (channel != null && channel.Status == 2)
                {
                    if (channel.Source != null && channel.Source.clip == clip)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static AudioChannel GetEmptyChannel(List<AudioChannel> channels)
        {
            foreach (var channel in channels)
            {
                if (channel != null && channel.Status == 0)
                {
                    return channel;
                }
            }
            return null;
        }

        public static AudioChannel PlayEffect(string soundName, float pitch)
        {
            AudioClip clip;
            if (_clipTable.TryGetValue(soundName, out clip))
            {
                if (!IsExistReservation(_effectChannels, clip))
                {
                    foreach (var channel in _effectChannels)
                    {
                        if (channel != null && channel.Status == 0)
                        {
                            channel.Source.clip = clip;
                            channel.Source.pitch = pitch;
                            channel.Volume = 1.0f;
                            channel.ResetVolume();
                            channel.Status = 2;
                            return channel;
                        }
                    }
                }
            }
            return null;
        }

        public static AudioChannel CrossFadeStreamDirect(AudioClip clip, float duration, float time)
        {
            if (_streamChannels.Count < 2)
            {
                throw new System.IndexOutOfRangeException();
            }

            var channel1 = _streamChannels[0];
            var channel2 = _streamChannels[1];

            if (channel1 == null || channel2 == null)
            {
                // Handle error...
            }

            _streamChannels[0] = channel2;
            _streamChannels[1] = channel1;

            StopStream(1, duration);

            channel2.Source.clip = clip;
            channel2.Source.time = time;
            channel2.Volume = 0;
            channel2.ResetVolume();
            channel2.Duration = duration;
            channel2.Status = 2; // Assuming 2 is a specific status code
            channel2.Source.loop = true;

            return channel2;
        }

        public static void StopStream(int channelIndex, float duration)
        {
            if (channelIndex >= _streamChannels.Count)
            {
                throw new System.IndexOutOfRangeException();
            }

            var channel = _streamChannels[channelIndex];

            if (channel == null)
            {
                return;
            }

            if (channel.Source == null || channel.Source.clip == null)
            {
                return;
            }

            channel.Status = duration != 0.0f ? 6 : 7;
            channel.Duration = duration;
            channel.ElapsedTime = 0.0f;
        }

        public static AudioChannel PlayStreamDirect(int channelIndex, AudioClip clip, float time)
        {
            if (channelIndex >= _streamChannels.Count)
            {
                throw new System.IndexOutOfRangeException();
            }

            var channel = _streamChannels[channelIndex];

            if (channel == null)
            {
                return null;
            }

            channel.Source.clip = clip;
            channel.Source.time = time;
            channel.Status = 2;

            return channel;
        }

        public static (AudioChannel, AudioChannel) PlayStreamWithIntro(string introStreamName, string loopStreamName)
        {
            var introChannel = PlayStream(1, introStreamName, 0.0f);
            var loopChannel = PlayStream(0, loopStreamName, 0.0f);

            var introSource = introChannel.Source;
            var loopSource = loopChannel.Source;

            double dspTime = AudioSettings.dspTime;

            introSource.PlayScheduled(dspTime);
            introSource.loop = false;
            introChannel.Status = 0;

            dspTime = AudioSettings.dspTime;
            var introClip = introSource.clip;
            int samples = introClip.samples;
            int frequency = introClip.frequency;

            loopSource.PlayScheduled(dspTime + (double)samples / frequency);
            loopChannel.Status = 0;

            return (introChannel, loopChannel);
        }

        public static AudioChannel PlayStream(int channelIndex, string soundName, float time)
        {
            AudioClip clip;
            if (!_clipTable.TryGetValue(soundName, out clip))
            {
                return null;
            }

            if (channelIndex >= _streamChannels.Count)
            {
                throw new IndexOutOfRangeException();
            }

            var channel = _streamChannels[channelIndex];
            if (channel != null)
            {
                var source = channel.Source;
                source.clip = clip;
                source.time = time;
                channel.Duration = 0.0f;
                channel.Volume = 1.0f; // Assuming 0x23f800000 is equivalent to 1.0f in float
                channel.ResetVolume();
            }

            return channel;
        }

        public static void PauseStream(int channelIndex)
        {
            if (channelIndex >= _streamChannels.Count)
            {
                throw new IndexOutOfRangeException();
            }

            var channel = _streamChannels[channelIndex];
            if (channel != null)
            {
                var source = channel.Source;
                if (source != null && source.clip != null)
                {
                    channel.Status = 4; // Assuming 4 is a status code for "paused"
                }
            }
        }

        public static void Update(float deltaTime)
        {
            for (int i = 0; i < channelList.Count; i++)
            {
                var channelGroup = channelList[i];
                for (int j = 0; j < channelGroup.Count; j++)
                {
                    var channel = channelGroup[j];
                    if (channel != null)
                    {
                        channel.ElapsedTime += deltaTime;
                        switch (channel.Status)
                        {
                            case 2:
                                channel.Source.Play();
                                channel.Status = channel.Duration <= 0.0f ? 3 : 5;
                                break;
                            case 3:
                                if (!channel.Source.isPlaying)
                                    channel.Status = 7;
                                break;
                            case 4:
                                channel.Source.Pause();
                                channel.Status = 1;
                                break;
                            case 5:
                                channel.Volume = Mathf.Min(channel.ElapsedTime / channel.Duration, 1.0f);
                                channel.ResetVolume();
                                if (channel.Volume == 1.0f)
                                    channel.Status = 3;
                                break;
                            case 6:
                                channel.Volume = 1.0f - Mathf.Min(channel.ElapsedTime / channel.Duration, 1.0f);
                                channel.ResetVolume();
                                if (channel.Volume == 0.0f)
                                    channel.Status = 7;
                                break;
                            case 7:
                                channel.Source.Stop();
                                channel.Source.clip = null;
                                channel.Status = 0;
                                break;
                        }
                        channel.ElapsedTime = 0.0f;
                    }
                }
            }
        }

        private void OnDestroy()
        {
            _clipTable.Clear();
        }

        public bool AddClip(string clipName, AudioClip clip)
        {
            if (clip == null)
            {
                return false;
            }
            if (!_clipTable.ContainsKey(clipName))
            {
                _clipTable.Add(clipName, clip);
                return true;
            }
            return false;
        }

        public void RemoveClip(string clipName)
        {
            if (_clipTable.ContainsKey(clipName))
            {
                _clipTable.Remove(clipName);
            }
        }

        static AudioPlayer()
        {
            _clipTable = new Dictionary<string, AudioClip>(StringComparer.CurrentCultureIgnoreCase);
            _streamChannels = new AudioChannel[2].ToList();
            _effectChannels = new AudioChannel[16].ToList();
            _voiceChannels = new AudioChannel[4];
            _audioListener = null;
            _currentAudioListener = null;
            _listenerTables = new Dictionary<string, AudioListener>();
        }
    }
}
