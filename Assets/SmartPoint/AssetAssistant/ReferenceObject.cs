using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    [Serializable]
    public struct ReferenceObject
    {
        public UnityEngine.GameObject asset;

        public string path;
    }
}
