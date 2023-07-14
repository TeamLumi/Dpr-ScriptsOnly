using System;
using System.Linq;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
    {
        public static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    // Load the instance from resources if it's not already loaded
                    instance = Resources.FindObjectsOfTypeAll<T>().FirstOrDefault();

                    if (instance == null)
                    {
                        Logger.Log("An instance of " + typeof(T) +
                        " is needed in the scene, but there is none.");
                    }
                }
                return instance;
            }
        }

        public string ClassName
        {
            get { return typeof(T).Name; }
        }

        public void OnEnable()
        {
            if (instance == null)
            {
                instance = this as T;
            }
        }
    }
}