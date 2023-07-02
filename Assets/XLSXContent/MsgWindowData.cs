using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class MsgWindowData : ScriptableObject
    {
        public SheetSpeakerNameData[] SpeakerNameData;

        public SheetRoadsignViewData[] RoadsignViewData;

        public SheetRoadsignResourceData[] RoadsignResourceData;

        public SheetWindowFrameData[] WindowFrameData;

        public SheetWindowBGData[] WindowBGData;

        public SheetTextureResourceData[] TextureResourceData;

        public SheetAssetResourceData[] AssetResourceData;

        public SheetSoundTagData[] SoundTagData;

        [Serializable]
        public class SheetAssetResourceData
        {
            public int id;

            public string assetBundlePath;
        }

        [Serializable]
        public class SheetRoadsignResourceData
        {
            public int id;

            public string textureName;

            public int width;

            public int height;
        }

        [Serializable]
        public class SheetRoadsignViewData
        {
            public int id;

            public int roadSignID;

            public float rotZ;

            public Vector3 position;
        }

        [Serializable]
        public class SheetSoundTagData
        {
            public int id;

            public string soundEventName;
        }

        [Serializable]
        public class SheetSpeakerNameData
        {
            public string label;

            public string talk_label;
        }

        [Serializable]
        public class SheetTextureResourceData
        {
            public int id;

            public string textureName;
        }

        [Serializable]
        public class SheetWindowBGData
        {
            public int id;

            public string textureName;
        }

        [Serializable]
        public class SheetWindowFrameData
        {
            public int winType;

            public string textureName;
        }
    }
}
