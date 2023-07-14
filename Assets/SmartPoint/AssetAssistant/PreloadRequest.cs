using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    [Serializable]
    public sealed class PreloadRequest : ScriptableObject
    {
        private static PreloadRequest instance;

        public static PreloadRequest[] GetPreloadRequests()
        {
            var x = GetInstance();
            PreloadRequest[] preloadRequests;

            if (x != null)
            {
                preloadRequests = ((PreloadRequest)instance).PreloadRequests;
            }
            else
            {
                preloadRequests = null; // Default value in case instance is null
            }

            return preloadRequests;
        }

        private static object GetInstance()
        {
            if (instance == null)
            {
                instance = new PreloadRequest(); // Instance creation logic should go here
            }

            return instance;
        }

        public string[] assetBundleName;

        public bool loadAllAssets;

        public PreloadRequest[] PreloadRequests { get; private set; }
    }
}
