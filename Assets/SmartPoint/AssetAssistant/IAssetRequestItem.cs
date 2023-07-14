using System;

namespace SmartPoint.AssetAssistant
{
    public interface IAssetRequestItem
    {
        RequestStatus status { get; set; }

        string uri { get; set; }

        AssetBundleDownloadManifest manifest { get; set; }

        bool isComplete { get; }

        RequestEventCallback callback { get; set; }

        string error { get; set; }
    }
}
