using System;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI
{
    public class NowloadingController : MonoBehaviour
    {
        private void Awake()
        {
        }

        public void Open(float waitTime = 5f, int sortOrder = 16390)
        {
        }

        public void Close()
        {
        }

        private void Setup(float waitTime = 5f, int sortOrder = 16390)
        {
        }

        private void OnUpdate(float deltaTime)
        {
        }

        private void SetActive(bool active)
        {
        }

        public void EnableBackground(bool enabled)
        {
        }

        [SerializeField]
        private Animator _animatorLoading;

        [SerializeField]
        private Image _imageBackground;

        private float _waitTime;

        private float _progressTime;

        private bool _isWaiting;

        private static readonly int animStatePlay;

        private float _animLength;

        private float _animTime;
    }
}
