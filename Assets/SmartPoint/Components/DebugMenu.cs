using SmartPoint.AssetAssistant;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SmartPoint.Components
{
    public class DebugMenu : SingletonMonoBehaviour<DebugMenu>
    {
        public class EventCallback
        {
            // All functions are declared as extern without a body.
            // You have to replace these with actual implementations.
            public extern EventCallback(object @object, IntPtr method);
            public virtual extern void Invoke(bool visibled);
            public virtual extern IAsyncResult BeginInvoke(bool visibled, AsyncCallback callback, object @object);
            public virtual extern void EndInvoke(IAsyncResult result);
        }

        private Image _image;
        private bool _isOpaque;
        public GameObject Template;

        public static DebugMenu Instance;
        public MenuInstance RootMenu;
        public RectTransform InformationWindow;
        public TMPro.TextMeshProUGUI InformationText;

        private MenuInstance _globalMenu;
        private MenuInstance _nextMenu;

        public class TryCallback
        {
            public extern TryCallback(object @object, IntPtr method);
            public virtual extern bool Invoke();
            public virtual extern IAsyncResult BeginInvoke(AsyncCallback callback, object @object);
            public virtual extern bool EndInvoke(IAsyncResult result);
        }

        public class MenuInstance : MonoBehaviour
        {
            public class InnerClass1
            {
                public GameObject gameObject1;
                public GameObject gameObject2;
                public GameObject gameObject3;

                internal void Method1(object reference) { }
                internal bool Method2(object x) { return false; }
            }

            public class InnerClass2
            {
                public GameObject cell;
                internal bool Method1(object x) { return false; }
            }

            public class InnerClass3
            {
                public GameObject selectedObject;
                internal bool Method1(object x) { return false; }
            }

            public GameObject OwnerCell { get; set; }
            public string Caption { get; set; }
            public GameObject ScrollView { get; set; }
            public GameObject GameObject { get; set; }
            public int CurrentIndex { get; set; }
            public GameObject Parent { get; set; }
            public GameObject Canvas { get; set; }
            public GameObject CanvasGroup { get; set; }
            public GameObject LayoutGroup { get; set; }
            public GameObject Cells { get; set; }

            public MenuInstance(string caption, GameObject gameObject, object scrollView) { }

            internal void SetVisible(bool v)
            {
                throw new NotImplementedException();
            }

        }

        // Add the rest of your fields here...

        public bool IsOpaque
        {
            get
            {
                return this._isOpaque;
            }
            set
            {
                this._isOpaque = value;
                Color color = this._image.color;
                color.a = value ? 1.0f : 0.0f; // changes the alpha value based on the IsOpaque value.
                this._image.color = color;
            }
        }

        private void OnEnable()
        {
            onActiveChange?.Invoke(true);
        }

        private void OnDisable()
        {
            onActiveChange?.Invoke(false);
        }

        public bool GetActive()
        {
            return this.gameObject.activeSelf;
        }

        public void SetActive(bool value)
        {
            if (this.gameObject.activeSelf != value)
            {
                this.gameObject.SetActive(value);
            }
        }

        public void SetVisibled(bool value)
        {
            IsVisible = value;
        }

        public bool IsVisible
        {
            get
            {
                var instance = SingletonMonoBehaviour<DebugMenu>.Instance;

                if (instance != null)
                {
                    return instance.enabled;
                }
                return false;
            }
            set
            {
                var instance = SingletonMonoBehaviour<DebugMenu>.Instance;

                if (instance == null)
                    return;

                if (!value)
                {
                    var currentEventSystem = EventSystem.current;

                    if (currentEventSystem != null)
                    {
                        currentEventSystem.SetSelectedGameObject(null);
                    }
                }
                else if (!IsVisible)
                {
                    if (_currentMenu != null)
                    {
                        _currentMenu.IsVisible = true;
                    }
                }

                instance.enabled = value;

                // Assuming there is a CanvasGroup component attached to the same GameObject.
                var canvasGroup = instance.GetComponent<CanvasGroup>();

                if (canvasGroup != null)
                {
                    canvasGroup.interactable = value;
                    canvasGroup.blocksRaycasts = value;
                }

                onVisibleChanged?.Invoke(value);
            }
        }

        public DebugMenu Parent { get; private set; }

        public MenuInstance Create(string caption, MenuInstance parent)
        {
            if (Instance == null)
                return null;

            GameObject newMenuObj = Instantiate(Template, Instance.transform);

            Canvas canvas = newMenuObj.GetComponentInChildren<Canvas>();
            CanvasGroup canvasGroup = newMenuObj.GetComponentInChildren<CanvasGroup>();
            //LayoutScrollView scrollView = newMenuObj.GetComponentInChildren<LayoutScrollView>();

            if (canvas != null && canvasGroup != null /*&& scrollView != null*/)
            {
                newMenuObj.SetActive(true);

                MenuInstance newMenuInstance = new MenuInstance(caption, newMenuObj, null /*scrollView*/);

                if (RootMenu == null)
                {
                    RootMenu = newMenuInstance;
                    // TODO: Implement system_array_init() equivalent if needed
                }
                else
                {
                    newMenuInstance.SetVisible(false);
                }

                if (parent != null)
                {
                    //parent.AddMenu(newMenuInstance);
                }

                return newMenuInstance;
            }

            return null;
        }

        public bool GetInformationWindowEnable()
        {
            if (Instance == null)
                return false;

            var canvas = InformationWindow.GetComponent<Canvas>();

            if (canvas == null)
                return false;

            return canvas.enabled;
        }

        public void ShowInformationWindow(bool show)
        {
            if (Instance == null)
                return;

            var canvas = InformationWindow.GetComponent<Canvas>();

            if (canvas != null && canvas.enabled != show)
                canvas.enabled = show;
        }

        public void SetInformationText(string text)
        {
            if (Instance != null)
            {
                if (InformationText != null)
                {
                    InformationText.text = text;
                    InformationText.ForceMeshUpdate();
                }
            }
        }

        public void SetRoot(MenuInstance menuInstance)
        {
            SetVisibled(false);

            if (_rootMenu != null)
            {
                _rootMenu.SetVisible(false);
            }

            //_rootMenu = menuInstance;

            if (_rootMenu == null)
            {
                //_rootMenu = _globalMenu;
            }

            _currentMenu = null;
            _nextMenu = null;
        }

        public DebugMenu GetRoot()
        {
        if (_rootMenu == null)
            {
                if (_globalMenu == null)
                    {
                        _globalMenu = Create(/*StringLiteral_18390*/ "Debug Menu", null);
                        //system_array_init();
                    }

                //_rootMenu = _globalMenu;
                //system_array_init();
            }

            return _rootMenu;
        }

        private void Awake()
        {
            //SingletonMonoBehaviour<DebugMenu>.Awake();
            SetVisibled(false);
            _image = GetComponent<Image>();
            ShowInformationWindow(false);
        }

        private void Start()
        {
            //Sequencer.Update += OnUpdate;
        }

        private void OnDestroy()
        {
            //Sequencer.Update -= OnUpdate;
        }

        //public static MenuInstance GetCurrentMenu()
        //{
            //return _currentMenu;
        //}

        public static void SetCurrentMenu(MenuInstance currentMenu)
        {
            if (_currentMenu == null)
            {
                //_currentMenu = GetRoot();
            }

            if (currentMenu == null)
            {
                //currentMenu = GetRoot();
            }

            if (_currentMenu == currentMenu)
            {
                return;
            }

            if (_currentMenu != null)
            {
                _currentMenu.SetVisible(false);
            }

            //_currentMenu = currentMenu;
            _currentMenu.SetVisible(true);
        }

        public static void GoBack()
        {
            if (_currentMenu == _rootMenu)
            {
                //SetVisible(false);
                return;
            }

            _currentMenu.SetVisible(false);
            _currentMenu = _currentMenu.Parent;
            _currentMenu.SetVisible(true);
        }

        private void SetVisible(bool v)
        {
            throw new NotImplementedException();
        }

        private void OnUpdate()
        {
            // OnUpdate logic here
        }

        public static DebugMenu _currentMenu;
        public static DebugMenu _rootMenu;

        // This is a placeholder for onVisibleChanged event, you may need to replace it with your actual implementation.
        public static event Action<bool> onVisibleChanged;

        public static EventCallback onActiveChange;
    }
}
