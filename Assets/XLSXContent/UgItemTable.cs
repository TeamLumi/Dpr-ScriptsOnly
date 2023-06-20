using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class UgItemTable : ScriptableObject
    {
        public UgItemTable.Sheettable Item
        {
            get
            {
                return null;
            }
        }

        public UgItemTable()
        {
        }

        public UgItemTable.Sheettable[] table;

        [Serializable]
        public class Sheettable
        {
            public Sheettable()
            {
            }

            public int UgItemID;

            public int ItemTableID;

            public int TamatableID;

            public int PedestaltableID;

            public int StonestatueeffectID;
        }
    }
}
