using System;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

namespace SmartPoint.AssetAssistant
{
    public class AssetBundleRequestItem : IAssetRequestItem
    {
        private bool loadDependencies;

        public AssetBundleRequestItem(AssetBundleDownloadManifest __manifest, string __uri, bool __loadAllAssets, bool __loadDependencies, string[] __variants = null)
        {
            manifest = __manifest;
            uri = __uri;
            variants = __variants;
            loadDependencies = __loadDependencies;
            loadAllAssets = __loadAllAssets;
        }

        public bool isComplete
        {
            get { return status == RequestStatus.Complete; }
        }

        public RequestStatus status
        {
            get { return status; }
            set { status = value; }
        }

        public AssetBundleDownloadManifest manifest
        {
            get { return manifest; }
            set { manifest = value; }
        }

        public string uri
        {
            get { return uri; }
            set { uri = value; }
        }

        public UnityWebRequest webRequest
        {
            get { return webRequest; }
            set { webRequest = value; }
        }

        public FileStream fileStream
        {
            get { return fileStream; }
            set { fileStream = value; }
        }

        public string[] variants
        {
            get { return variants; }
            set { variants = value; }
        }

        public bool loadAllAssets
        {
            get { return loadAllAssets; }
            set { loadAllAssets = value; }
        }

        public AssetBundleCache cache
        {
            get { return cache; }
            set { cache = value; }
        }

        public AssetBundleCreateRequest createRequest
        {
            get { return createRequest; }
            set { createRequest = value; }
        }

        public AsyncOperation assetRequest
        {
            get { return assetRequest; }
            set { assetRequest = value; }
        }

        public RequestEventCallback callback
        {
            get { return callback; }
            set { callback = value; }
        }

        public string error
        {
            get { return error; }
            set { error = value; }
        }

        public CustomYieldInstruction customInstruction
        {
            get { return customInstruction; }
            set { customInstruction = value; }
        }
    }
}
