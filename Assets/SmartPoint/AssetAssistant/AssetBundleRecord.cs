using SmartPoint.AssetAssistant;
using SmartPoint.AssetAssistant.UnityExtensions;
using System;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    [Serializable]
    public class AssetBundleRecord
    {
        public string projectName;
        public string assetBundleName;
        public RecordedHash hash;
        public DateTime lastWriteTime;
        public bool isStreamingSceneAssetBundle;
        public string[] allDependencies;
        public string[] assetPaths;
        public long size;
        [NonSerialized]
        public AssetBundleRecord latest;
        [NonSerialized]
        public bool isBeginInstalled;
        [NonSerialized]
        public bool isSimulation;

        public AssetBundleRecord(string _projectName, string _assetBundleName)
        {
            projectName = _projectName;
            assetBundleName = _assetBundleName;
            allDependencies = ArrayHelper.Empty<string>();
            assetPaths = Sequencer.editorProxy.GetAssetPathsFromAssetBundle(assetBundleName);

            if (assetPaths.Length == 0)
            {
                Logger.Log($"AssetBundleRecord: assetPaths is empty for {_projectName}/{_assetBundleName}");
            }

            if (assetPaths.Length > 0)
            {
                isStreamingSceneAssetBundle = SceneDatabase.instance.Contains(assetPaths[0]);
                for (int i = 0; i < assetPaths.Length; i++)
                {
                    assetPaths[i] = assetPaths[i].ToLower();
                }
            }
        }

        public AssetBundleRecord(AssetBundleRecord other)
        {
            projectName = other.projectName;
            assetBundleName = other.assetBundleName;
            hash = other.hash;
            lastWriteTime = other.lastWriteTime;
            allDependencies = other.allDependencies;
            assetPaths = other.assetPaths;
            size = other.size;
            isStreamingSceneAssetBundle = other.isStreamingSceneAssetBundle;
            isSimulation = false;
        }
    }
}