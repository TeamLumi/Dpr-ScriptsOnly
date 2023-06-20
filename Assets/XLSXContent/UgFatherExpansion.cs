using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class UgFatherExpansion : ScriptableObject
    {
        public SheetExpansion[] Expansion;

        // This is a simple version of the get_Item method
        public SheetExpansion get_Item(int index)
        {
            if (index < 0 || index >= Expansion.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range for Expansion array.");
            }

            return Expansion[index];
        }

        [Serializable]
        public class SheetExpansion
        {
            public int ugItemID01;
            public int amount01;

            public int ugItemID02;
            public int amount02;

            public int ugItemID03;
            public int amount03;

            public int ugItemID04;
            public int amount04;

            public int ugItemID05;
            public int amount05;
        }
    }
}
