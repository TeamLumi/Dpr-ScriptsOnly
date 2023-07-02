using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class ContestWazaInfo : ScriptableObject
    {
        public ContestWazaInfo()
        {

        }

        public SheetContestWazaData[] ContestWazaData;

        [Serializable]
        public class SheetContestWazaData
        {
            public SheetContestWazaData()
            {

            }

            public bool valid_flag;

            public ushort id;

            public int wazaType;

            public int appealPoint;

            public int value1;

            public int value2;

            public string labelName;
        }
    }
}
