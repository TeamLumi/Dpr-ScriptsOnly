using System;
using UnityEngine;

namespace Audio
{
    public class AudioData
    {
        public int Release()
        {
            //int result = base.Release();
            //if (result == 0)
            //{
            //_loadState = 3;
            //var bankCallback = new AkCallbackManager.BankCallback();
            //AkSoundEngine.UnloadBank(_bankId, 0, bankCallback, this);
            //}
            //return result;
            return 0;
        }

        private void UnloadCallback(uint bankId, IntPtr bankPtr, int result, object data)
        {
            //AudioManager.Unload(this);
        }

        public string _bankName;

        public uint _bankId;

        public GameObject _loadState;

        public sealed class LoadState : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject Loading;

            public GameObject Loaded;

            public GameObject Unloading;
        }
    }
}
