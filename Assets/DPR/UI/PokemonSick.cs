using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Dpr.Battle.Logic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI
{
    public class PokemonSick : MonoBehaviour
    {
        public int sick
        {
            get
            {
                return default(int);
            }
        }

        public void Setup(PokemonParam pokemonParam)
        {
        }

        public void Setup(BTL_POKEPARAM btlParam)
        {
        }

        public void Setup(int sick)
        {
        }

        public PokemonSick()
        {
        }

        [SerializeField]
        private CanvasGroup _canvasGroup;

        [SerializeField]
        private Image _image;

        private TweenerCore<float, float, FloatOptions> _fadeTw;

        private const int _sickPoizon = 6;

        private const int _sickDying = 7;

        private static string[] _spriteNames;

        private int _sick;
    }
}
