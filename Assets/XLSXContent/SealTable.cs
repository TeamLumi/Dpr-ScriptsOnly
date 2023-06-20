using System;
using System.Drawing;
using System.Reflection;
//using Pml.PokePara;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class SealTable : ScriptableObject
    {
        public XLSXContent.SealTable.SheetSealData GetItem(XLSXContent.SealTable thisSealTable, int index)
        {
            if (index < thisSealTable.SealData.Length)
            {
                return thisSealTable.SealData[index];
            }
            else
            {
                // The original C++ code throws an exception here, which we can also do in C#
                throw new ArgumentOutOfRangeException("index", $"Index is out of range. The valid range is 0 to {thisSealTable.SealData.Length - 1}");
            }
        }

        public SealTable.SheetSealData[] SealData;

        public SealTable.SheetEffectPositionOffset[] EffectPositionOffset;

        public SealTable.SheetFixedPositionEffect[] FixedPositionEffect;

        [Serializable]
        public class SheetSealData
        {
            public SealID SealID;

            public int Category;

            public int SortNumber;

            public int EffectType;

            public string EffectAssetbundleName;

            public bool IsEffectYAxisToForward;

            public string IconAssetbundleName;
        }

        [Serializable]
        public class SheetEffectPositionOffset
        {
            public Size Size;

            public float OffsetValue;
        }

        [Serializable]
        public class SheetFixedPositionEffect
        {
            public SealID SealID;

            public Vector3 Position;

            public Vector3 Rotation;

            public Vector3 AdjustScaleRate;
        }
    }
}
