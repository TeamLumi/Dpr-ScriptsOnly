using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SmartPoint.AssetAssistant.Forms
{
    public class MessageBox
    {
        private static MessageBoxManifestBase _manifest;
        private static GameObject _window;
        private static Transform _buttonLayout;
        private static OnClick _onClick;
        private static Dictionary<GameObject, MessageBoxResult> _buttonMaps;

        public delegate void OnClick(MessageBoxResult result);

        public static void SetManifest(MessageBoxManifestBase manifest)
        {
            _manifest = manifest;
        }

        public static bool Show(string message, string caption, MessageBoxButtons buttons, string[] buttonNames, OnClick onClick = null)
        {
            if (_manifest == null)
            {
                Logger.Log("Manifest not set yet.");
                return false;
            }

            if (_window != null)
                return false;

            _window = GameObject.Instantiate(_manifest.windowPrefab);
            _window.name = "Message Box";

            _onClick = onClick;

            var text = _window.GetComponentsInChildren<Text>();
            if (text.Length <= 0)
            {
                // TODO: Handle missing text components
            }
            foreach (var t in text)
            {
                if (t.name == _manifest.captionTextObjectName)
                {
                    // TODO: Set the caption text
                }
            }

            var tran = _window.GetComponentsInChildren<Transform>();
            foreach (var tr in tran)
            {
                if (tr.name == _manifest.buttonLayoutObjectName)
                {
                    _buttonLayout = tr.transform;
                }
            }

            Object.DontDestroyOnLoad(_window);

            CreateButtons(_manifest, buttons, buttonNames);

            return true;
        }

        public static void Show(string message, string caption, MessageBoxButtons buttons, OnClick onClick = null)
        {
            Show(message, caption, buttons, null, onClick);
        }

        private static void CreateButtons(MessageBoxManifestBase manifest, MessageBoxButtons buttons, string[] buttonNames)
        {
            _buttonMaps = new Dictionary<GameObject, MessageBoxResult>();

            switch (buttons)
            {
                case MessageBoxButtons.None:
                    {
                        AddTrigger(_window);
                        break;
                    }
                case MessageBoxButtons.AbortRetryIgnore:
                    {
                        if (buttonNames.Length >= 3)
                        {
                            CreateButton(manifest, MessageBoxResult.Abort, buttonNames[0]);
                            CreateButton(manifest, MessageBoxResult.Retry, buttonNames[1]);
                            CreateButton(manifest, MessageBoxResult.Cancel, buttonNames[2]);
                        }
                        if (buttonNames.Length > 0)
                        {
                            CreateButtonSeparator(manifest);
                        }
                        break;
                    }
                case MessageBoxButtons.OK:
                    {
                        if (buttonNames.Length > 0)
                        {
                            CreateButton(manifest, MessageBoxResult.OK, buttonNames[0]);
                        }
                        break;
                    }
                case MessageBoxButtons.OKCancel:
                    {
                        if (buttonNames.Length > 1)
                        {
                            CreateButton(manifest, MessageBoxResult.OK, buttonNames[0]);
                            CreateButton(manifest, MessageBoxResult.Cancel, buttonNames[1]);
                        }
                        break;
                    }
                case MessageBoxButtons.RetryCancel:
                    {
                        if (buttonNames.Length > 1)
                        {
                            CreateButton(manifest, MessageBoxResult.Retry, buttonNames[0]);
                            CreateButton(manifest, MessageBoxResult.Cancel, buttonNames[1]);
                        }
                        break;
                    }
                case MessageBoxButtons.YesNo:
                    {
                        if (buttonNames.Length > 1)
                        {
                            CreateButton(manifest, MessageBoxResult.Yes, buttonNames[0]);
                            CreateButton(manifest, MessageBoxResult.No, buttonNames[1]);
                        }
                        break;
                    }
                case MessageBoxButtons.YesNoCancel:
                    {
                        if (buttonNames.Length > 2)
                        {
                            CreateButton(manifest, MessageBoxResult.Yes, buttonNames[0]);
                            CreateButton(manifest, MessageBoxResult.No, buttonNames[1]);
                            CreateButton(manifest, MessageBoxResult.Cancel, buttonNames[2]);
                        }
                        break;
                    }
                default:
                    return;
            }
        }

        private static void CreateButtonSeparator(MessageBoxManifestBase manifest)
        {
            if (manifest.buttonSeparatorPrefab != null)
            {
                var sep = GameObject.Instantiate(manifest.buttonSeparatorPrefab);
                if (sep != null)
                {
                    sep.name = "Separator";
                    _buttonMaps.Add(sep, new MessageBoxResult());
                }
            }
        }

        private static void CreateButton(MessageBoxManifestBase manifest, MessageBoxResult result, string name, string text = null)
        {
            var button = GameObject.Instantiate(manifest.buttonPrefab);
            if (button != null)
            {
                var txt = button.GetComponentInChildren<Text>();
                if (txt != null)
                {
                    txt.name = name;
                    if (text != null) txt.text = text;
                    AddTrigger(button);
                    _buttonMaps.Add(button, result);
                }
            }
        }

        private static void AddTrigger(GameObject instance)
        {
            EventTrigger trig = instance.GetComponent<EventTrigger>();
            if (trig == null)
                trig = (EventTrigger)instance.AddComponent(typeof(EventTrigger));

            EventTrigger.Entry ent = new EventTrigger.Entry();
            ent.eventID = EventTriggerType.PointerClick;
            //ent.callback = OnPointerClickDelegate; // TODO: figure out
            trig.triggers.Add(ent);
        }

        public static void OnPointerClickDelegate(BaseEventData baseData)
        {
            if (baseData == null) Hide();
            else
            {
                var obj = baseData.selectedObject;
                if (obj == null) Hide();
                else
                {
                    MessageBoxResult res;
                    if (_buttonMaps.TryGetValue(obj, out res))
                    {
                        _onClick.Invoke(res);
                    }
                }
            }
        }

        public static void Hide()
        {
            foreach (var b in _buttonMaps)
            {
                if (b.Key != null)
                {
                    GameObject.DestroyImmediate(b.Key);
                }
            }
            if (_window != null) GameObject.DestroyImmediate(_window);
        }

        public MessageBox()
        {
            _buttonMaps = new Dictionary<GameObject, MessageBoxResult>();
        }
    }
}
