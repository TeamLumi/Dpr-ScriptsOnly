using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;
using SmartPoint.AssetAssistant.SmartPoint.AssetAssistant;

namespace SmartPoint.AssetAssistant
{
    public class AssetRequestOperation : CustomYieldInstruction
    {
        private List<IAssetRequestItem> _requests = new List<IAssetRequestItem>();

        // Constructors
        public AssetRequestOperation(IAssetRequestItem requestItem)
        {
            if (requestItem == null)
            {
                throw new ArgumentNullException(nameof(requestItem));
            }

            _requests.Add(requestItem);
        }

        public AssetRequestOperation(List<IAssetRequestItem> requestItems)
        {
            if (requestItems == null || requestItems.Count == 0)
            {
                throw new ArgumentNullException(nameof(requestItems));
            }

            _requests.AddRange(requestItems);
        }

        // Properties
        public IReadOnlyList<IAssetRequestItem> Requests => _requests;

        public IAssetRequestItem Request => _requests.FirstOrDefault();

        public AssetRequestItem AssetRequest
        {
            get
            {
                return _requests.OfType<AssetRequestItem>().FirstOrDefault();
            }
        }

        public AssetBundleRequestItem AssetBundleRequest
        {
            get
            {
                return _requests.OfType<AssetBundleRequestItem>().FirstOrDefault();
            }
        }

        public List<AssetRequestItem> AssetRequests
        {
            get
            {
                return _requests.OfType<AssetRequestItem>().ToList();
            }
        }

        public List<AssetBundleRequestItem> AssetBundleRequests
        {
            get
            {
                return _requests.OfType<AssetBundleRequestItem>().ToList();
            }
        }

        public override bool keepWaiting => throw new NotImplementedException();
    }
}
