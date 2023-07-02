using System;
using System.Collections.Generic;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class RareFishTable : ScriptableObject
    {
        public List<Sheettengan> tengan;

        [Serializable]
        public class Sheettengan
        {
            public int X_axis;

            public int Y_axis;
        }
    }
}
