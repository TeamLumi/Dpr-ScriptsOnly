using System;
using System.Collections;
using UnityEngine;

namespace Dpr.Demo
{
    [Serializable]
    public abstract class DemoBase
    {
        protected sealed class BGType : ScriptableObject
        {
            public GameObject PoffinEat;

            public GameObject HakaseRed;

            public GameObject HakaseBlue;

            public GameObject Evolve;

            public GameObject Gosanke;
        }

        private sealed class Enter
        {
            public int state;

            public object current;

            public Enter(int state)
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class Main
        {
            public int state;

            public object current;

            private object Current => null;

            public Main(int state)
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class Exit
        {
            public int state;

            public object current;

            private object Current => null;

            public Exit(int state)
            {
            }

            private void Dispose()
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class _WaitMessageWindow
        {
            public int state;

            public object current;

            public bool isCloseWindow;

            private object Current => null;

            public _WaitMessageWindow(int state)
            {
            }

            private void Dispose()
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class _LoadBackGround
        {
            public int state;

            public object current;

            public GameObject OnLoad;

            private object System_002ECollections_002EGeneric_002EIEnumeratorSystem_002EObject_002ECurrent => null;

            private object Current => null;

            public _LoadBackGround(int state)
            {
            }

            private void Dispose()
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class _LoadPokeAsset
        {
            public int state;

            public object current;

            public GameObject param;

            public bool isHideRare;

            public bool isBattleModel;

            private object Current => null;

            public _LoadPokeAsset(int state)
            {
            }

            private void Dispose()
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }

        private sealed class c__DisplayClass70_0 //Wrong?
        {
            public GameObject catalog;

            public string pokeBundleName;

            internal void LoadPokeAsset(object eventType, string name, UnityEngine.Object asset)
            {
            }
        }

        /*
        private sealed class _LoadPokeAsset
        {
            public int state;

            public object current;

            public GameObject monsNo;

            public ushort formNo;

            public GameObject sex;

            public bool isRare;

            public bool isEgg;

            public bool isBattleModel;

            private object Current => null;

            public _LoadPokeAsset(int state)
            {
            }

            private void Dispose()
            {
            }

            private bool MoveNext()
            {
                return false;
            }

            private void Reset()
            {
            }
        }
        */

        public GameObject cameraController;

        public GameObject manager;

        public GameObject parent;

        public GameObject Tws;

        public Action OnEndDemo;

        public GameObject OnPreEndDemo;

        public bool UseCamera;

        public bool DisableEnvironmentController;

        public bool isUseAlpha;

        public bool isDisableEndLightSet;

        public bool isDisablePostProcess;

        public bool isDisableMainCamera;

        public int AddSortOrder;

        public GameObject Messages;

        public GameObject _messageWindow;

        public int nowMessageNo;

        public string AssetBundlePath;

        public GameObject POKE_VIEW_PREFAB_PATH;

        public GameObject RENDERCAMERA_PREFAB_PATH;

        public GameObject coroutines;

        public GameObject PokeAssets;

        public GameObject PokeAsset;

        public GameObject BG;

        public bool is2DBG;

        public GameObject bgType;

        public GameObject BGPaths;

        public bool UseStartEnterFade;

        public bool UseStartExitFade;

        public bool UseEndEnterFade;

        public bool UseEndExitFade;

        public float StartEnterFadeDuration;

        public float StartExitFadeDuration;

        public float EndEnterFadeDuration;

        public float EndExitFadeDuration;

        public Color FadeColor;

        protected Camera cam => null;

        protected bool PushA => false;

        protected bool PushB => false;

        protected bool PushX => false;

        protected bool PushY => false;

        protected bool PushAorB => false;

        protected bool KeyLeft => false;

        protected bool KeyRight => false;

        protected bool KeyDown => false;

        protected bool KeyUp => false;

        protected bool isMessageFinished => false;

        protected object nowMSG => null;

        protected bool isEnableInput => false;

        //public Color ClearColor => null;

        public virtual object PreloadAssetBundles()
        {
            return null;
        }

        public virtual void ReleasePreloadedAssetBundles()
        {
        }

        public string GetPokemonAssetBundle(object monsNo, ushort formNo, object sex, bool isRare, bool isBattleModel)
        {
            return "";
        }

        public virtual void Init()
        {
        }

        public virtual void PostProcessSetting()
        {
        }

        public virtual void _DebugMethod(int TestNo)
        {
        }

        public virtual void LightUpdate()
        {
        }

        protected IEnumerator WaitMessageWindow(bool isCloseWindow)
        {
            return null;
        }

        protected object DrawNextMessage()
        {
            return null;
        }

        protected object DrawMessage(int NextMessageNo)
        {
            return null;
        }

        protected void CloseWindow()
        {
        }

        protected object CreateMsgWindowParam(string msgFileName, string labelName, bool isCloseMessage)
        {
            return null;
        }

        protected IEnumerator LoadBackGround(object OnLoad)
        {
            return null;
        }

        public IEnumerator LoadPokeAsset(object param, bool isHideRare, bool isBattleModel)
        {
            return null;
        }

        public IEnumerator LoadPokeAsset(object monsNo, ushort formNo, object sex, bool isRare, bool isEgg, bool isBattleModel)
        {
            return null;
        }

        public void FadeSetting(bool fade1, bool fade2, bool fade3, bool fade4)
        {
        }

        public void SetFadeTime(bool t1, bool t2, bool t3, bool t4)
        {
        }

        public object RenderImageFade(bool alpha, bool duration)
        {
            return null;
        }

        public object RenderImageScale(bool scale, bool duration)
        {
            return null;
        }

        private void LoadBackGround(object eventType, string name, UnityEngine.Object asset)
        {
        }
    }
}
