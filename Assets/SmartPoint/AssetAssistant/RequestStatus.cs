using System;

namespace SmartPoint.AssetAssistant
{
    public enum RequestStatus
    {
        None,
        ResolveDependencies,
        LoadAndInstall,
        RequestInstallation,
        InstallAssetBundles,
        SaveManifest,
        WaitForInstallation,
        WaitForCacheLoading,
        WaitForCacheWriting,
        WaitForReloadShaders,
        LoadAssetBundle,
        LoadAsset,
        LoadFinished,
        Complete,
        HttpError,
        NetworkError,
        FileNotFound
    }
}
