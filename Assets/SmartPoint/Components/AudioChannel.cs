using UnityEngine;

namespace SmartPoint.Components
{
    public class AudioChannel
    {
        private AudioSource _source;
        private float _volume;
        private int _type;
        private int _status;
        private float _duration;
        private float _elapsedTime;

        public AudioChannel(int type, AudioSource source)
        {
            _volume = 1.0f;
            _type = type;
            _source = source;
            ResetVolume();
        }

        public void ResetVolume()
        {
            float volume;
            switch (_type)
            {
                case 3:
                    volume = AudioPlayer.GlobalVoiceVolume;
                    break;
                case 2:
                    volume = AudioPlayer.GlobalEffectVolume;
                    break;
                case 1:
                    volume = AudioPlayer.GlobalStreamVolume;
                    break;
                default:
                    volume = 0.0f;
                    break;
            }
            _source.volume = volume * _volume;
        }

        public AudioClip Clip
        {
            get => _source ? _source.clip : null;
            set
            {
                if (_source)
                    _source.clip = value;
            }
        }

        public float Time
        {
            get => _source ? _source.time : 0.0f;
            set
            {
                if (_source)
                    _source.time = value;
            }
        }

        public float Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                ResetVolume();
            }
        }

        public bool IsPlaying => _source && _source.isPlaying;

        public void Play() => _status = 2;

        public void Stop() => _status = 7;

        public void Pause() => _status = 4;

        public AudioSource Source => _source;

        public int Status
        {
            get => _status;
            set => _status = value;
        }

        public float Duration
        {
            get => _duration;
            set => _duration = value;
        }

        public float ElapsedTime
        {
            get => _elapsedTime;
            set => _elapsedTime = value;
        }
    }
}
