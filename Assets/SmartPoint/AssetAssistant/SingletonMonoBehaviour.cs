using System;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    [DisallowMultipleComponent]
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
    {
        private static T instance;
        private static bool isApplicationQuitting = false;

        public static bool IsQuit
        {
            get { return isApplicationQuitting; }
        }

        public static bool IsInstantiated
        {
            get { return instance != null; }
        }

        public static T Instance
        {
            get
            {
                if (isApplicationQuitting)
                {
                    Logger.Log("Instance '" + typeof(T) +
                        "' already destroyed on application quit." +
                        " Won't create again - returning null.");
                    return null;
                }

                if (instance == null)
                {
                    instance = (T)FindObjectOfType(typeof(T));

                    if (FindObjectsOfType(typeof(T)).Length > 1)
                    {
                        Logger.Log("More than one instance of Singleton: " + typeof(T));
                        return instance;
                    }

                    if (instance == null)
                    {
                        GameObject singleton = new GameObject();
                        instance = singleton.AddComponent<T>();
                        singleton.name = "(singleton) " + typeof(T).ToString();

                        DontDestroyOnLoad(singleton);
                    }
                }

                return instance;
            }
        }

        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(this.gameObject);
            }
            else if (instance != this)
            {
            Destroy(gameObject);
            }
        }

        protected virtual void OnApplicationQuit()
        {
            isApplicationQuitting = true;
        }

        public static T Instantiate(string instanceName = null, Transform parent = null)
        {
            if (!string.IsNullOrEmpty(instanceName))
            {
                Instance.name = instanceName;
                if (parent != null)
                {
                    Instance.transform.SetParent(parent);
                }
            }
            return Instance;
        }
    }
}