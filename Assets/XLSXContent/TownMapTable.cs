using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class TownMapTable
    {
        public object Item
        {
            get
            {
                return null;
            }
        }

        public GameObject Data;

        [Serializable]
        public class SheetData : ScriptableObject
        {
            public GameObject zoneID;

            public int Width;

            public int Index1;

            public int Index2;

            public int Index3;

            public Vector2 NowPosXZ;

            public Vector2 TownPosXZ;

            public Vector2 MarkingMapPosXZ;

            public string GuideText1;

            public string GuideText2;

            public string TownMapName;

            public GameObject ViewFlag;

            public GameObject ColorOnFlag;

            public string SymbolName;

            public GameObject AddGuideFlag;

            public GameObject ChangFacilityFlag;

            public int ChangFacilityNo;

            public string Facility00;

            public string Facility01;

            public string Facility02;

            public string Facility03;

            public string Facility04;

            public string Facility05;

            public string Facility06;

            public string FacilitySP;

            public bool FlyingAvailablePlace;

            public int MapInfoLocatorIndex;

            public bool AreaHideFlag;
        }
    }
}
