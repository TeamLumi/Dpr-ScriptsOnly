using SmartPoint.AssetAssistant.UnityExtensions;
using System.Collections.Generic;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class AssetBundleCache : RefCounted
    {
        private static Dictionary<string, AssetBundleCache> _container;
        private AssetBundleRecord _record;
        private AssetBundle _assetBundle;
        private bool _isLoaded;
        private string[] _variants;
        private Object[] _loadedAssets;
        private bool _unloadAllLoadedObjects;
        private string[] _remapDependencies;

        public Object loadedFirstAsset
        {
            get => loadedAssets[0];
        }

        public Object[] loadedAssets
        {
            get => _loadedAssets;
            set => _loadedAssets = value;
        }

        public string[] variants
        {
            get => _variants;
        }

        public string[] remapDependencies
        {
            get => _remapDependencies;
        }

        public bool allLoaded
        {
            get
            {
                bool ret = false;
                if (_loadedAssets.Length < 1)
                    ret = true;
                else
                {
                    int i = 0;
                    for (i = 0; i < _loadedAssets.Length; i++)
                    {
                        if (_loadedAssets[i] != null) break;
                    }
                    if (i == _loadedAssets.Length - 1) ret = true;
                }
                return ret;
            }
        }

        public AssetBundleRecord record
        {
            get => _record;
            set => _record = value;

        }

        public AssetBundle assetBundle
        {
            get => _assetBundle;
            set => _assetBundle = value;

        }

        public bool isLoaded
        {
            get => _isLoaded;
            set => _isLoaded = value;

        }

        public bool canLoadAsset
        {
            get
            {
                bool ret = false;
                int i = 0;
                foreach (string d in _remapDependencies)
                {

                    if (!string.IsNullOrEmpty(d))
                    {
                        AssetBundleCache cache;
                        var val = _container.TryGetValue(d, out cache);
                        if (!val || cache == null) break;
                    }
                    if (++i >= _remapDependencies.Length)
                        ret = true;
                }
                return ret;
            }
        }

        private AssetBundleCache() : base()
        {
            _loadedAssets = ArrayHelper.Empty<Object>();
            _container = new Dictionary<string, AssetBundleCache>();
        }

        public override int Release()
        {
            if (referencedCount == 1)
            {
                _unloadAllLoadedObjects = false;
                return referencedCount;
            }
            Logger.Log("Unload asset-bundle:" + _record.assetBundleName);
            _record = null;
            if (assetBundle != null)
            {
                assetBundle.Unload(_unloadAllLoadedObjects);
                assetBundle = null;
            }
            referencedCount--;
            return referencedCount;
        }

        public static bool Contains(string assetBundleName, bool includeNotLoaded = false)
        {
            AssetBundleCache c = null;
            if (!string.IsNullOrEmpty(assetBundleName))
                _container.TryGetValue(assetBundleName, out c);
            return c != null;
        }

        public static AssetBundleCache Add(AssetBundleRecord record, bool isLoaded = false, string[] variants = null)
        {
            return (AssetBundleCache)null;
        }

        public static AssetBundleCache Get(string assetBundleName, bool includeNotLoaded = false)
        {
            return (AssetBundleCache)null;
        }

        public static int ReleaseFromAssetBundleChache(AssetBundleCache cache, bool unloadAllLoadedObjects = false)
        {
            int ret = 0;
            foreach (var dep in cache._record.allDependencies)
            {
                AssetBundleCache c;
                if (!string.IsNullOrEmpty(dep))
                {
                    if (_container.TryGetValue(dep, out c))
                    {
                        c._unloadAllLoadedObjects = unloadAllLoadedObjects;
                        c.Release();
                    }
                }
            }
            return ret;
        }

        public static int ReleaseFromAssetBundleName(string assetBundleName, bool unloadAllLoadedObjects = false)
        {
            int ret = 0;
            AssetBundleCache c;
            if (_container.TryGetValue(assetBundleName, out c))
            {
                ret = ReleaseFromAssetBundleChache(c, unloadAllLoadedObjects);
            }

            return ret;
        }

        public static void Destroy()
        {
            foreach (var c in _container)
            {
                //c.Value.Unload(false);
            }

            _container.Clear();
        }
    }
}