using System;
using UnityEngine;

namespace Dpr.Movie
{
    public class MoviePlayer : ScriptableObject
    {
        public GameObject movieMaterial;

        public GameObject _videoPlayer;

        public GameObject _switchVideoPlayer;

        public int ResX;

        public int ResY;

        public GameObject _rendererImage;

        public bool _isPlaying;

        public bool isUpdateVideoOnThisFrame;
    }
}