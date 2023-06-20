using UnityEngine;

namespace SmartPoint.Components
{
    public class AudioChannel
    {
        public int _type;
        public AudioSource _source;
        public float _volume;
        public int _status;
        public float _duration;
        public float _elapsedTime;

        public AudioClip Clip
        {
            get
            {
                if (_source != null)
                {
                    return _source.clip;
                }
                return null;
            }
            set
            {
                _source.clip = value;
            }
        }

        public float Time
        {
            get
            {
                if (_source != null)
                {
                    return _source.time;
                }
                return 0.0f;
            }
            set
            {
                _source.time = value;
            }
        }

        public float Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
                ResetVolume();
            }
        }

        public bool IsPlaying
        {
            get
            {
                return _source.isPlaying;
            }
        }

        public AudioSource Source
        {
            get
            {
                return _source;
            }
        }

        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public float Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }

        public float ElapsedTime
        {
            get
            {
                return _elapsedTime;
            }
            set
            {
                _elapsedTime = value;
            }
        }

        public AudioChannel(object type, AudioSource source)
        {
        }

        public void Play()
        {
            _status = 2;
        }

        public void Stop()
        {
            _status = 7;
        }

        public void Pause()
        {
            _status = 4;
        }

        public void ResetVolume()
        {
            float globalVolume = 0.0f;

            switch (_type)
            {
                case 3:
                    globalVolume = AudioPlayer.globalVoiceVolume;
                    break;
                case 2:
                    globalVolume = AudioPlayer.globalEffectVolume;
                    break;
                case 1:
                    globalVolume = AudioPlayer.globalStreamVolume;
                    break;
            }

            _source.volume = globalVolume * _volume;
        }
    }
}
