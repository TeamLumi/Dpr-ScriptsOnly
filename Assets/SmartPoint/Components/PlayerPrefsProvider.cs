using System;

namespace SmartPoint.Components
{
    public abstract class PlayerPrefsProvider<T> where T : new()
    {
        public string Key
        {
            get
            {
                return typeof(T).FullName;
            }
        }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = Activator.CreateInstance<T>();
                }
                return instance;
            }
        }

        public void Initialization()
        {
            return;
        }

        public bool CustomLoadOperation()
        {
            return false;
        }

        public bool CustomSaveOperation()
        {
            return false;
        }

        public bool CustomLoadAsyncOperation()
        {
            //ulong result = CustomLoadOperation(); // Assuming CustomLoadOperation returns a ulong

            //if ((result & 1) != 0) // Check if the least significant bit is set
            //{
                //OnPostLoad(); // Assuming OnPostLoad is a method of this class
                //return true;
            //}

            return false;
        }

        public void CustomSaveAsyncOperation()
        {
            //function1?.Invoke();
            //function2?.Invoke();
        }

        public void OnPostLoad()
        {
            return;
        }

        public void OnPreSave()
        {
            return;
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
