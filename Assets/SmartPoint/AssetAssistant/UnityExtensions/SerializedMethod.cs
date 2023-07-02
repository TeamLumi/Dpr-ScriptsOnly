using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using UnityEngine;

namespace SmartPoint.AssetAssistant.UnityExtensions
{
    [Serializable]
    public struct SerializedMethod
    {
        public string assemblyQualifiedName
        {
            get
            {
                return null;
            }
        }

        public string methodName
        {
            get
            {
                return null;
            }
        }

        public bool isStatic
        {
            get
            {
                return default(bool);
            }
        }

        //public SerializedMethod(string assemblyQualifiedName, string methodName, bool isStatic)
        //{
        //}

        //public SerializedMethod(MethodInfo methodInfo)
        //{
        //}

        public void Invoke()
        {
        }

        public void Invoke(object obj, object[] parameters)
        {
        }

        public MethodInfo GetMethodInfo()
        {
            return null;
        }

        public RuntimeMethodHandle GetMethod()
        {
            return default(RuntimeMethodHandle);
        }

        public T GetDelegate<T>() where T : class, ICloneable, ISerializable
        {
            return null;
        }

        [SerializeField]
        private string _assemblyQualifiedName;

        [SerializeField]
        private string _methodName;

        [SerializeField]
        private bool _isStatic;
    }
}
