using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.Movie
{
    public class EndingPlayer
    {
        public void Initialize(object moviePlayer, bool diaVersion, object lang, bool male, int bodyType, object fadeImage, UnityAction endCallback, object staffrollPlayer)
        {
        }

        private IEnumerator LoadAssets()
        {
            return null;
        }

        private void UnloadAssets()
        {
        }

        public void Play()
        {
        }

        public IEnumerator PlayEnding()
        {
            return null;
        }

        private IEnumerator EndEnding()
        {
            return null;
        }

        private void OnUpdate(bool deltaTime)
        {
        }

        private string GetMoviePath()
        {
            return "";
        }

        private void GetLogoPath(object path, object name)
        {
        }

        private void GetEndTextPath(object path, object name)
        {
        }

        private void PlayBGM()
        {
        }

        private void StopBGM()
        {
        }

        public GameObject _fadeImage;

        public UnityAction _endCallback;

        public GameObject _staffrollPlayer;

        public GameObject _state;

        public float _lastVideoTime;

        public float _timeCounter;

        public bool _enableSkip;

        public GameObject _waitInputTime;

        public bool _diaVersion;

        public GameObject _lang;

        public bool _male;

        public int _bodyType;

        public string _moviePath;

        public string _logoPath;

        public string _endTextPath;

        public bool _isLoadedAssets;

        public string logoFile;

        public GameObject logoTex;

        public string endTextFile;

        public GameObject endTextTex;
    }

    //private sealed class EndingState : ScriptableObject
    //{
        //public GameObject None;

        //public GameObject PlayingMovie;

        //public GameObject WaitInput;

        //public GameObject End;
    //}
}
