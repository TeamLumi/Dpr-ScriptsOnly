using System;
using UnityEngine;

namespace Dpr
{
    [Serializable]
    public class PokeAnimSound
    {
        public bool Enable
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public void Init(AnimationPlayer animationPlayer)
        {
        }

        public void Update(Transform transform)
        {
        }

        private int getAnimEventIndex(int clipIndex, float time)
        {
            return default(int);
        }

        public PokeAnimSound()
        {
        }

        public const uint SND_SWITCH_GROUP = 3000483895U;

        public const uint SND_SWITCH_STATE = 1893047300U;

        public PokeAnimSound.AnimEventData[] AnimEvent;

		private AnimationPlayer _animationPlayer;

        private int _oldClipIndex;

        private int _oldEventIndex;

        [Serializable]
        public class AnimEventData
        {
            public AnimEventData()
            {
            }

            public int[] Frame;

            public uint[] EventSymbol;
        }
    }
}
