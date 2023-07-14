using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class TownMapGuideTable
    {
        public object Item
        {
            get
            {
                return null;
            }
        }

        public GameObject Guide;

        [Serializable]
        public class SheetGuide : ScriptableObject
        {
            public int Id;

            public int TownMapX;

            public int TownMapY;

            public string MSFile;

            public string MSLabel;
        }
    }
}
