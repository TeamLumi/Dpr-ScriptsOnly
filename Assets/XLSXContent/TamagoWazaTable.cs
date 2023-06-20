using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class TamagoWazaTable : ScriptableObject
    {
        public TamagoWazaTable()
        {
        }

        public TamagoWazaTable.SheetData[] Data;

        [Serializable]
        public class SheetData
        {
            public SheetData()
            {
            }

            public ushort no;

            public ushort formNo;

            public ushort[] wazaNo;
        }
    }
}
