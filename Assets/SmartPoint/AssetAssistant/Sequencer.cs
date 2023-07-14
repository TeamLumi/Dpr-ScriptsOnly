using SmartPoint.AssetAssistant.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using static SmartPoint.AssetAssistant.Sequencer;
using static UnityEngine.Application;
using static Dpr.LogSender;
using Dpr;

namespace SmartPoint.AssetAssistant
{
    public sealed class Sequencer : SingletonMonoBehaviour<Sequencer>
    {
        public enum WebhookTarget
        {
            None,
            Discord,
            Slack,
        }

        public const int StringBuilderCapaity = 1024;
        private static IUnityEditorProxy _editorProxy;
        private static List<(int, TickCallback)> _orderableList;
        private static Dictionary<Coroutine, Coroutine> _subToOwner;
        private static Dictionary<Coroutine, Coroutine> _ownerToSub;
        private static Coroutine _referenceCoroutine;
        private static List<UnityEngine.Object> _trashObjects;
        private static List<LogMessage> _messageList;
        private static Queue<string> _messageQueue;
        private static WebhookTarget _webhookTarget;
        private static bool _onetimeSkipFlag;
        public static EventCallback start;
        public static EventCallback onDestroy;
        public static EventCallback onFinalize;
        public static EventCallback applicationQuit;
        public static TickCallback earlyUpdate;
        public static TickCallback update;
        public static TickCallback afterUpdate;
        public static TickCallback earlyLateUpdate;
        public static TickCallback lateUpdate;
        public static TickCallback postLateUpdate;
        public static TickCallback onEndOfFrame;
        private static WaitForEndOfFrame waitForEndOfFrame;

        public static StringBuilder stringBuilder { get; private set; }
        public static float elapsedTime { get; private set; }
        public static int nativeScreenWidth { get; private set; }
        public static int nativeScreenHeight { get; private set; }
        public static float nativeAspectRatio { get; private set; }
        public static int ScreenWidth { get; private set; }
        public static int ScreenHeight { get; private set; }
        public static float AspectRatio { get; private set; }
        public static bool isSuspendUpdate { get; set; }

        public static List<ValueTuple<int, TickCallback>> orderableList;
        private static Dictionary<Coroutine, Coroutine> subToOwner;
        private static Dictionary<Coroutine, Coroutine> ownerToSub;
        private static Coroutine referenceCoroutine;
        private static List<UnityEngine.Object> trashObjects;

        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            waitForEndOfFrame = new WaitForEndOfFrame();
            Instantiate();
        }

        public static IUnityEditorProxy editorProxy
        {
            get
            {
                if (_editorProxy == null && Application.isEditor)
                {
                    string assemblyPath;
                    string typeName = "The name of the type implementing IUnityEditorProxy";

                    if (Type.GetType("The name of the type implementing IUnityEditorProxy").Assembly.FullName.Contains("The string to check"))
                    {
                        assemblyPath = Path.Combine(Directory.GetCurrentDirectory(), "The relative path to the assembly");
                    }
                    else
                    {
                        assemblyPath = "The path to the assembly";
                    }

                    var assembly = Assembly.LoadFile(assemblyPath);

                    if (assembly != null)
                    {
                        var type = assembly.GetType(typeName);
                        var method = type.GetMethod("The method to invoke");

                        _editorProxy = (IUnityEditorProxy)method.Invoke(null, null);
                    }
                }

                return _editorProxy;
            }
        }

        public void Awake()
        {
            StartupSettings StartupSettings = Resources.Load<StartupSettings>("StartupSettings");
            Dpr.LogSender.Instance.Init(this, StartupSettings.webhookURL);

            // Union Room stuff
            //if (!SingletonMonoBehaviour<UnionRoomManager>.Awake(this))
            //{
            //return false;
            //}

            //int id = 0;
            //while (true)
            //{
            //if (id >= 256)
            //{
            //break;
            //}
            //var item = new LogMessage(id);
            //this.MessageList.Add(item);
            //id++;
            //}

            if (!string.IsNullOrEmpty(StartupSettings.webhookURL))
            {
                if (!Application.isEditor || StartupSettings.webhookInEditMode)
                {
                    if (StartupSettings.webhookURL.Contains("discord"))
                    {
                        _webhookTarget = WebhookTarget.Discord;
                        Logger.Log("Boot Initialized");
                    }
                    if (StartupSettings.webhookURL.Contains("slack"))
                    {
                        _webhookTarget = WebhookTarget.Slack;
                        Logger.Log("Boot Initialized");
                    }
                    else
                    {
                        _webhookTarget = WebhookTarget.None;
                        Logger.Log("No Webhook Found.");
                    }
                }
            }

            int userFramerate = 30;
            Application.targetFrameRate = userFramerate;

            string productName = Application.productName;
            Logger.Log($"Product Name: {productName}");

            nativeScreenWidth = Screen.width;
            nativeScreenHeight = Screen.height;
            nativeAspectRatio = (float)Screen.width / (float)Screen.height;

            start?.Invoke();

            start = null;

            //MessageBoxManifestBase messageBoxManifest = StartupSettings.messageBoxManifest;
            //MessageBox.Manifest = messageBoxManifest;
            
            // NexInitializer

            // EventSystem

            // AudioManager

            // UIManager

            // EffectManager

            // FontManager

            // NetworkManager

            Logger.Log("[Sequencer] Finished Start sequence");
        }


        public static void SubscribeUpdate(int order, TickCallback callback)
        {
            UnsubscribeUpdate(callback);

            var index = _orderableList.FindIndex(x => x.Item1 == order);

            if (index == -1)
            {
                _orderableList.Add((order, callback));
            }
            else
            {
                _orderableList.Insert(index, (order, callback));
            }
        }

        public static void UnsubscribeUpdate(TickCallback callback)
        {
            var index = _orderableList.FindIndex(x => x.Item2 == callback);

            if (index != -1)
            {
                _orderableList.RemoveAt(index);
            }
        }

        public static void Trash(UnityEngine.Object trashObject)
        {
            _trashObjects.Add(trashObject);
        }

        public static Coroutine Start(IEnumerator routine)
        {
            if (Instance == null)
            {
                Logger.Log("Error: Sequencer is null");
                return null;
            }
            var rout = Instance.StartCoroutine(RunCoroutine(routine));
            if (_referenceCoroutine != null)
            {
                _ownerToSub.Add(rout, _referenceCoroutine);
            }
            return rout;
        }

        public static IEnumerator RunCoroutine(IEnumerator routine)
        {
            return routine;
        }

        public static void Stop(Coroutine coroutine)
        {
            if (coroutine != null && SingletonMonoBehaviour<Sequencer>.Instance != null)
            {
                SingletonMonoBehaviour<Sequencer>.Instance.StopCoroutine(coroutine);

                if (_ownerToSub.TryGetValue(coroutine, out Coroutine subCoroutine))
                {
                    Stop(subCoroutine);
                    _subToOwner.Remove(subCoroutine);
                }

                _ownerToSub.Remove(coroutine);
            }
        }

        public static bool IsFinished(Coroutine coroutine) => new bool();

        public static void Update()
        {
            float deltaTime = Time.deltaTime;
            elapsedTime = deltaTime;

            //foreach (var item in _orderableList)
            for (int i = 0; i < orderableList.Count; i++)
            {
                //var callback = item as TickCallback;
                //callback?.Invoke(deltaTime);
                orderableList[i].Item2(deltaTime);
            }

            if (_trashObjects.Count > 0)
            {
                foreach (var obj in _trashObjects)
                {
                    UnityEngine.Object.DestroyImmediate(obj);
                }
                _trashObjects.Clear();
            }

            start?.Invoke();
            start = null;

            earlyUpdate?.Invoke(elapsedTime);
            update?.Invoke(elapsedTime);
        }

        private IEnumerator AfterUpdate() => (IEnumerator)null;

        public void LateUpdate()
        {
            if (_onetimeSkipFlag)
            {
                _onetimeSkipFlag = false;
                return;
            }

            if (isSuspendUpdate)
            {
                return;
            }

            int newWidth = Screen.width;
            int newHeight = Screen.height;

            if (newWidth != ScreenWidth || newHeight != ScreenHeight)
            {
                ScreenWidth = newWidth;
                ScreenHeight = newHeight;
                AspectRatio = (float)newWidth / newHeight;

                Logger.Log($"Screen size changed: {ScreenWidth}x{ScreenHeight}");

                // Assuming GameObjects implement IViewportChangeHandler
                var gameObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
                foreach (var go in gameObjects)
                {
                    if (ExecuteEvents.CanHandleEvent<IViewportChangeHandler>(go))
                    {
                        ExecuteEvents.Execute<IViewportChangeHandler>(go, null, (handler, data) => handler.OnViewportChange());
                    }
                }
            }

            float deltaTime = Time.deltaTime;

            earlyLateUpdate?.Invoke(deltaTime);
            lateUpdate?.Invoke(deltaTime);
            postLateUpdate?.Invoke(deltaTime);
        }

        public interface IViewportChangeHandler : UnityEngine.EventSystems.IEventSystemHandler
        {
            void OnViewportChange();
        }


        void OnDestroy()
        {
            onDestroy?.Invoke();

            onFinalize?.Invoke();

            applicationQuit?.Invoke();

            if (applicationQuit != null)
            {
                earlyUpdate = null;
                update = null;
                afterUpdate = null;
                earlyLateUpdate = null;
                lateUpdate = null;
                postLateUpdate = null;
                onDestroy = null;

                Resources.UnloadUnusedAssets();
            }
        }

        private void OnApplicationQuit()
        {
            // Invoke the applicationQuit event if it's not null
            applicationQuit?.Invoke();

            // Set the applicationQuit event to null
            applicationQuit = null;
        }

        public static Component AddComponent(Type componentType) => (Component)null;

        public static T AddComponent<T>() where T : Component => (T)null;

        public void RemoveComponent(System.Type componentType)
        {
            if (Instance != null)
            {
                var component = Instance.gameObject.GetComponent(componentType);
                if (component != null)
                {
                    DestroyImmediate(component);
                }
            }
        }

        public static void RemoveComponent<T>() where T : Component
        {
            if (Instance != null)
            {
                var component = Instance.gameObject.GetComponent<T>();
                if (component != null)
                {
                    DestroyImmediate(component);
                }
            }
        }

        public static void LogReceiver(string condition, string stackTrace, LogType type)
        {
            var messageList = Sequencer._messageList;
            var nextId = LogMessage.nextID;

            if (messageList.Count <= nextId)
            {
                throw new ArgumentOutOfRangeException();
            }

            messageList[nextId].AdvanceAndSet(condition, stackTrace, type);

            var messageQueue = Sequencer._messageQueue;
            if (messageQueue != null)
            {
                if (type == LogType.Error)
                {
                    messageQueue.Enqueue(condition);
                }
                else
                {
                    messageQueue.Enqueue($"{condition}\n{stackTrace}");
                }
            }
        }

        public LogMessage GetLastLog()
        {
            if (LogMessage.lastID != 0)
            {
                return _messageList[LogMessage.lastID];
            }
            return null;
        }

        public static LogMessage[] GetLogs(int startID)
        {
            int lastID = LogMessage.lastID;
            if (lastID < startID)
            {
                return new LogMessage[0];
            }
            else
            {
                return _messageList.GetRange(startID, lastID - startID + 1).ToArray();
            }
        }


        private string FormatMessage(string message) => (string)null;

        public static bool IntersectGUI(Vector3 position) => new bool();

        public static List<RaycastResult> GetIntersectGUIs(Vector3 position) => (List<RaycastResult>)null;

        public Sequencer() : base()
        {
            _editorProxy = null;
            _orderableList = new List<(int, TickCallback)>();
            _subToOwner = new Dictionary<Coroutine, Coroutine>();
            _ownerToSub = new Dictionary<Coroutine, Coroutine>();
            _referenceCoroutine = null;
            _trashObjects = new List<UnityEngine.Object>();
            _messageList = new List<LogMessage>();
            _messageQueue = new Queue<string>();
            _onetimeSkipFlag = true;
            stringBuilder = new StringBuilder();
            elapsedTime = 0f;
            waitForEndOfFrame = null;
        }

        public delegate void EventCallback();

        public delegate void TickCallback(float deltaTime);
    }
}
