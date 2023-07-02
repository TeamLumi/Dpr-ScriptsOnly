using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class TitleSettings : ScriptableObject
    {
        public SheetStaffroll[] Staffroll;

        // This is a simple version of the get_Item method
        public SheetStaffroll get_Item(int index)
        {
            if (index < 0 || index >= Staffroll.Length)
            {
                throw new IndexOutOfRangeException($"Index {index} is out of range for Staffroll array.");
            }

            return Staffroll[index];
        }

        [Serializable]
        public class SheetStaffroll
        {
            public float LogoX;
            public float LogoY;
            public float LogoScale;
            public float TextX;
            public float TextY;
            public float TextScale;
        }
    }
}
