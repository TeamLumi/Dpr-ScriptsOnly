using System;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    namespace SmartPoint.AssetAssistant
    {
        public class AssetRequestItem
        {
            private AssetBundleDownloadManifest _manifest;
            private string _uri;
            private string _assetBundleName;
            private int _status;
            private UnityEngine.AsyncOperation _resourceRequest;
            private RequestEventCallback _callback;
            private string _error;

            public AssetRequestItem(AssetBundleDownloadManifest manifest, string assetName)
            {
                this._uri = assetName;
                this._manifest = manifest;
                this._status = 1;
            }

            public UnityEngine.Object GetAsset()
            {
                if (this._resourceRequest != null)
                {
                    if (this._resourceRequest is UnityEngine.AssetBundleRequest)
                    {
                        return ((UnityEngine.AssetBundleRequest)this._resourceRequest).asset;
                    }

                    if (this._resourceRequest is UnityEngine.ResourceRequest)
                    {
                        return ((UnityEngine.ResourceRequest)this._resourceRequest).asset;
                    }
                }

                return null;
            }

            public bool IsComplete()
            {
                return this._status == 0xd;
            }

            public int Status
            {
                get { return this._status; }
                set { this._status = value; }
            }

            public AssetBundleDownloadManifest Manifest
            {
                get { return this._manifest; }
                set { this._manifest = value; }
            }

            public string Uri
            {
                get { return this._uri; }
                set { this._uri = value; }
            }

            public string AssetBundleName
            {
                get { return this._assetBundleName; }
                set { this._assetBundleName = value; }
            }

            public UnityEngine.AsyncOperation ResourceRequest
            {
                get { return this._resourceRequest; }
                set { this._resourceRequest = value; }
            }

            public RequestEventCallback Callback
            {
                get { return this._callback; }
                set { this._callback = value; }
            }

            public string Error
            {
                get { return this._error; }
                set { this._error = value; }
            }
        }
    }
}
