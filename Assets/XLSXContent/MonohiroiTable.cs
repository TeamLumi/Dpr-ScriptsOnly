using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class MonohiroiTable : ScriptableObject
    {
        public SheetMonoHiroi[] MonoHiroi;

        [Serializable]
        public class SheetMonoHiroi
        {
            public SheetMonoHiroi()
            {
                // Implicitly calls base constructor (object())
            }

            public int ID;

            public ulong Ratios;
        }
    }
}
