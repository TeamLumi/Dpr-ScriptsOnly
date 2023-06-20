using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class EvolveTable : ScriptableObject
    {
        public EvolveTable.SheetEvolve[] Evolve;

        [Serializable]
        public class SheetEvolve
        {
            public int id;
            public ushort[] ar;
        }
    }
}
