using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class WazaOboeTable : ScriptableObject
    {
        public WazaOboeTable()
        {
        }

        public WazaOboeTable.SheetWazaOboe[] WazaOboe;

        [Serializable]
        public class SheetWazaOboe
        {
            public SheetWazaOboe()
            {
            }

            public int id;

            public ushort[] ar;
        }
    }
}
