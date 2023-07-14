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

        public string AssemblyQualifiedName { get; set; }
        public string MethodName { get; set; }
        public bool IsStatic { get; set; }
        public MethodInfo Method { get; set; }

        //public SerializedMethod(string assemblyQualifiedName, string methodName, bool isStatic, MethodInfo method)
        //{
            //this.AssemblyQualifiedName = assemblyQualifiedName;
            //this.MethodName = methodName;
            //this.IsStatic = isStatic;
            //this.Method = method;
        //}

        //public SerializedMethod(MethodInfo methodInfo)
        //{
            //this.Method = methodInfo;
            //this.AssemblyQualifiedName = methodInfo.ReflectedType.AssemblyQualifiedName;
            //this.MethodName = methodInfo.Name;
            //this.IsStatic = methodInfo.IsStatic;
        //}

        public void Invoke()
        {
            var methodInfo = GetMethodInfo();
            if (methodInfo != null)
            {
                methodInfo.Invoke(null, null);
            }
        }

        public void Invoke(object obj, object[] parameters)
        {
            var methodInfo = GetMethodInfo();
            if (methodInfo != null)
            {
                methodInfo.Invoke(obj, parameters);
            }
        }

        private MethodInfo GetMethodInfo()
        {
            if (!string.IsNullOrEmpty(this.AssemblyQualifiedName) && !string.IsNullOrEmpty(this.MethodName))
            {
                var type = Type.GetType(this.AssemblyQualifiedName) ?? Type.GetType(this.AssemblyQualifiedName + ", Version=0.0.0.0, Culture=neutral, PublicKeyToken=null");
                if (type != null)
                {
                    var bindingFlags = this.IsStatic ? BindingFlags.Static : BindingFlags.Instance;
                    return type.GetMethod(this.MethodName, bindingFlags | BindingFlags.Public | BindingFlags.NonPublic);
                }
            }
            return null;
        }

        public RuntimeMethodHandle GetMethod()
        {
            var methodInfo = GetMethodInfo();
            return methodInfo != null ? methodInfo.MethodHandle : default;
        }

        [SerializeField]
        private string _assemblyQualifiedName;

        [SerializeField]
        private string _methodName;

        [SerializeField]
        private bool _isStatic;
    }
}
