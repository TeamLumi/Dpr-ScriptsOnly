using System;

namespace SmartPoint.Components
{
    public abstract class PlayerPrefsProvider<T> where T : new()
    {
        protected virtual string key
        {
            get { return null; }
        }

        protected virtual void Initialization()
        {
        }

        protected virtual bool CustomLoadOperation()
        {
            return default(bool);
        }

        protected virtual bool CustomSaveOperation()
        {
            return default(bool);
        }

        protected virtual bool CustomLoadAsyncOperation()
        {
            return default(bool);
        }

        protected virtual bool CustomSaveAsyncOperation()
        {
            return default(bool);
        }

        protected virtual void OnPostLoad()
        {
        }

        protected virtual void OnPreSave()
        {
        }

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }

        public static void Load(bool forceReload = false, bool isAsync = false)
        {
        }

        public static void Save(bool isAsync = false)
        {
        }

        public static void Clear()
        {
        }

        protected PlayerPrefsProvider()
        {
        }

        private bool _loaded;
        private static T _instance;
    }
}
