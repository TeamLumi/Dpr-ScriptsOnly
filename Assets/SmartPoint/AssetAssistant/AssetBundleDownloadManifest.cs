using System;
using System.Collections.Generic;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    [Serializable]
    public class AssetBundleDownloadManifest
    {
        public string projectName { get; set; }
        public string path { get; set; }
        public AssetBundleDownloadManifest latest { get; set; }
        public int recordCount { get; }
        public AssetBundleRecord[] records { get; }
        public long totalSize { get; }
        public long installSize { get; }
        public int installCount { get; }
        public AssetBundleRecord[] installAssetBundleRecords { get; }

        public static AssetBundleDownloadManifest Load(byte[] data)
        {
            return null;
        }

        public static AssetBundleDownloadManifest Load(string path, bool isSimulation = false)
        {
            return null;
        }

        public static AssetBundleDownloadManifest Load(string targetPath, AssetBundleManifest other, AssetBundleDownloadManifest.OnRecordCreated callback)
        {
            return null;
        }

        public string[] GetDependencies(string assetBundleName)
        {
            return null;
        }

        private void LoadFromAssetBundleManifest(string targetPath, AssetBundleManifest other, AssetBundleDownloadManifest.OnRecordCreated callback)
        {
        }

        public void Save(string path, bool force = false)
        {
        }

        public AssetBundleDownloadManifest()
        {
        }

        public void Append(string projectName, AssetBundleDownloadManifest appendManifest)
        {
        }

        private void MarkDifference(AssetBundleDownloadManifest latestManifest)
        {
        }

        private void BuildLookupTables()
        {
        }

        public AssetBundleRecord AddRecord(string projectName, string assetBundleName)
        {
            return null;
        }

        public void Clear()
        {
        }

        public bool IsExist(string assetBundleName)
        {
            return default(bool);
        }

        public string[] GetExists(string[] assetBundleNames)
        {
            return null;
        }

        public void RemoveRecords(string[] assetBundleNames)
        {
        }

        public void RestrictRecords(string[] assetBundleNames)
        {
        }

        public string[] GetAllAssetBundleNames()
        {
            return null;
        }

        public string[] GetAssetBundleNamesWithVariant()
        {
            return null;
        }

        public string FindMatchAssetBundleNameWithVariants(string assetBundleName, string[] variants)
        {
            return null;
        }

        public string GetAssetBundleNameAtPath(string path)
        {
            return null;
        }

        public AssetBundleRecord GetAssetBundleRecord(string assetBundleName)
        {
            return null;
        }

        public AssetBundleRecord[] GetAssetBundleRecordsWithDependencies(string assetBundleName)
        {
            return null;
        }

        private const int currentVersion = 6;

        [SerializeField]
        private int _version;

        [SerializeField]
        private string _projectName;

        [SerializeField]
        private AssetBundleRecord[] _records;

        [SerializeField]
        private string[] _assetBundleNamesWithVariant;

        [NonSerialized]
        private Dictionary<string, HashSet<string>> _variantMap;

        [NonSerialized]
        private Dictionary<string, AssetBundleRecord> _recordLookupFromAssetBundleName;

        [NonSerialized]
        private Dictionary<string, AssetBundleRecord> _recordLookupFromAssetPath;

        [NonSerialized]
        private bool _dirty;

        [NonSerialized]
        private string _path;

        [NonSerialized]
        private AssetBundleDownloadManifest _latest;

        public delegate void OnRecordCreated(AssetBundleRecord record);
    }

    //[Serializable]
    //public class AssetBundleRecord
    //{
        // Add properties and methods specific to AssetBundleRecord class
    //}
}
