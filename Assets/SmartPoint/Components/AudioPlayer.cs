using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SmartPoint.Components
{
    public class AudioPlayer
    {
        private static void OnSceneLoaded(Scene scene, LoadSceneMode sceneMode)
        {
        }

        private static void Initialize()
        {
        }

        //private static void OnBeforeSceneChanged(SceneEntity currentScene, SceneEntity targetScene)
        //{
        //}

        public static float globalStreamVolume
        {
            get { return default(float); }
            set { }
        }

        public static float globalEffectVolume
        {
            get { return default(float); }
            set { }
        }

        public static float globalVoiceVolume
        {
            get { return default(float); }
            set { }
        }

        private static bool IsExistReservation(AudioChannel[] channels, AudioClip clip)
        {
            return default(bool);
        }

        private static AudioChannel GetEmptyChannel(AudioChannel[] channels)
        {
            return null;
        }

        public static AudioChannel PlayEffect(string soundName, float pitch = 1f)
        {
            return null;
        }

        public static AudioChannel CrossFadeStreamDirect(AudioClip clip, float duration = 2f, float time = 0f)
        {
            return null;
        }

        public static AudioChannel PlayStreamDirect(int channelIndex, AudioClip clip, float time = 0f)
        {
            return null;
        }

        public static (AudioChannel, AudioChannel) PlayStreamWithIntro(string introStreamName, string loopStreamName)
        {
            return default((AudioChannel, AudioChannel));
        }

        public static AudioChannel PlayStream(int channelIndex, string soundName, float time = 0f)
        {
            return null;
        }

        public static void StopStream(int channelIndex, float duration)
        {
        }

        public static void PauseStream(int channelIndex)
        {
        }

        private static void Update(float deltaTime)
        {
        }

        public static void OnDestroy()
        {
        }

        public static bool AddClip(string clipName, AudioClip clip)
        {
            return default(bool);
        }

        public static void RemoveClip(string clipName)
        {
        }

        public AudioPlayer()
        {
        }

        private static Dictionary<string, AudioClip> _clipTable;
        private static AudioChannel[] _streamChannels;
        private static AudioChannel[] _effectChannels;
        private static AudioChannel[] _voiceChannels;
        private static AudioListener _audioListener;
        private static AudioListener _currentAudioListener;
        private static float _globalStreamVolume;
        private static float _globalEffectVolume;
        private static float _globalVoiceVolume;
        private static Dictionary<string, AudioListener> _listenerTables;
        private static AudioChannel[][] _channelList;
    }
}
