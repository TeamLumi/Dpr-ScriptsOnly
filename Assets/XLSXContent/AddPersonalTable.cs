using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class AddPersonalTable : ScriptableObject
    {
        public SheetAddPersonal GetItem(int index)
        {
            // Ensure the index is within the bounds of the array
            if (index < 0 || index >= AddPersonal.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            // Return the item at the given index
            return AddPersonal[index];
        }

        public SheetAddPersonal[] AddPersonal;

        [Serializable]
        public class SheetAddPersonal
        {
            public bool valid_flag;
            public ushort monsno;
            public ushort formno;
            public bool isEnableSynchronize;
            public byte escape;
            public bool isDisableReverce;
        }
    }
}
