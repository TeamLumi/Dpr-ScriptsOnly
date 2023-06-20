using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class StoneStatuEeffect : ScriptableObject
    {
        public StoneStatuEeffect.Sheettable GetItem(int index)
        {
            if (index < 0 || index >= table.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return table[index];
        }

        public StoneStatuEeffect()
        {
        }

        public StoneStatuEeffect.Sheettable[] table;

        [Serializable]
        public class Sheettable
        {
            public Sheettable()
            {
            }

            public ushort statueId;

            public int UgItemID;

            public int MSLabelId;
        }
    }
}
