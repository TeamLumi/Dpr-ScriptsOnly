using UnityEngine;

namespace SmartPoint.AssetAssistant.Forms
{
    [CreateAssetMenu]
    public abstract class MessageBoxManifestBase : ScriptableObject
    {
        public GameObject windowPrefab;
        public GameObject buttonPrefab;
        public GameObject buttonSeparatorPrefab;
        public string captionTextObjectName;
        public string messageTextObjectName;
        public string buttonLayoutObjectName;

        protected MessageBoxManifestBase()
        {
            //
        }
    }
}