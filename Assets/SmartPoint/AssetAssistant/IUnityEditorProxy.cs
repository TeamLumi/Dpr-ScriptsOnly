using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SmartPoint.AssetAssistant
{
    public interface IUnityEditorProxy
    {
        string[] GetAllAssetBundleNames();

        string GetAssetBundleNameAtPath(string path);

        bool HasAssetBundleNameAtPath(string path);

        string FindMatchAssetBundleNameWithVariants(string assetBundleName, string[] variants);

        string[] GetAssetBundleNamesWithVariant();

        string[] GetAssetPathsFromAssetBundle(string assetBundleName);

        AsyncOperation LoadLevelAdditiveAsyncInPlayMode(string path);

        UnityEngine.Object LoadMainAssetAtPath(string path);

        void ReloadEditorSkyboxShader();

        void ReloadEditorShadersInScene(Scene scene);

        void ReloadEditorShaders(UnityEngine.Object asset);

        void ReloadVariantAssets(UnityEngine.Object asset, string[] variants);

        bool IsSceneAssetAtPath(string path);

        CustomYieldInstruction ReloadEditorShadersOperation(UnityEngine.Object[] assets);
    }
}
