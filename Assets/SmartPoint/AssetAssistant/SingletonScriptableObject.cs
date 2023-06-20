using System;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public abstract class SingletonScriptableObject<T> : ScriptableObject where T : class, new()
    {
        private static T _instance;

        public static string className
        {
            get => Type.GetTypeFromHandle(typeof(T).TypeHandle).FullName;
        }

        protected static T instance
        {
            get => _instance;
        }

        protected virtual void OnEnable()
        {
            //TODO: no idea whats going on here
        }

        protected SingletonScriptableObject() : base()
        {
            //
        }
    }
}