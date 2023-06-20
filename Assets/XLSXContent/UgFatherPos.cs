using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class UgFatherPos : ScriptableObject
    {
        public UgFatherPos.SheetPos this[int index]
        {
            get
            {
                if (index >= 0 && index < Pos.Length)
                {
                    return Pos[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        public UgFatherPos()
        {
        }

        public UgFatherPos.SheetPos[] Pos;

        [Serializable]
        public class SheetPos
        {
            public SheetPos()
            {
            }

            public int ID;
            public int ugfatherCategory;

            public ZoneID ZoneID;

            public Vector2Int Locator;
        }
    }
}
