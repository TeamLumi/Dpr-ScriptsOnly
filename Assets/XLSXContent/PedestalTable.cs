using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class PedestalTable : ScriptableObject
    {
        public PedestalTable.SheetInfo Item
        {
            get
            {
                // Add logic here
                throw new IndexOutOfRangeException("Index out of range");
            }
        }

        public PedestalTable()
        {
            // Implicitly calls base constructor (ScriptableObject())
        }

        public PedestalTable.SheetInfo[] Info;

        [Serializable]
        public class SheetInfo
        {
            public SheetInfo()
            {
                // Implicitly calls base constructor (object())
            }

            public ushort pedestalId;
            public int ugItemID;
            public string ItemNameLabel;
            public string DescriptionTextLabel;
            public byte Width;
            public byte Height;
            public float Offset;
            public float RotateSpeed;
            public bool Legend;
            public byte ModelIndex;
            public string AssetBundleName;
            public ushort sort;
        }
    }
}
