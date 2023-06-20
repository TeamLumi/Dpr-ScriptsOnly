using System;
using System.Collections.Generic;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class GrowTable : ScriptableObject
    {
        public List<GrowTable.SheetData> Data;

        [Serializable]
        public class SheetData
        {
            public uint[] exps;
        }
    }
}