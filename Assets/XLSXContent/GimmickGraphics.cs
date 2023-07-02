using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class GimmickGraphics : ScriptableObject
    {
        public GimmickGraphics()
        {

        }

        public SheetData[] Data;

        [Serializable]
        public class SheetData
        {
            public SheetData()
            {

            }

            public string AssetPath;
        }
    }
}
