using Pml;
using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class WazaTable : ScriptableObject
    {
        public WazaTable.SheetWaza Item
        {
            get
            {
                return null;
            }
        }

        public WazaTable()
        {
        }

        public WazaTable.SheetWaza[] Waza;

        public WazaTable.SheetYubiwohuru[] Yubiwohuru;

        [Serializable]
        public class SheetWaza
        {
            public WazaNo wazaNo;

            public bool isValid;

            public byte type;

            public byte category;

            public byte damageType;

            public byte power;

            public byte hitPer;

            public byte basePP;

            public sbyte priority;

            public byte hitCountMax;

            public byte hitCountMin;

            public ushort sickID;

            public byte sickPer;

            public byte sickCont;

            public byte sickTurnMin;

            public byte sickTurnMax;

            public byte criticalRank;

            public byte shrinkPer;

            public ushort aiSeqNo;

            public sbyte damageRecoverRatio;

            public sbyte hpRecoverRatio;

            public byte target;

            public byte rankEffType1;

            public byte rankEffType2;

            public byte rankEffType3;

            public sbyte rankEffValue1;

            public sbyte rankEffValue2;

            public sbyte rankEffValue3;

            public byte rankEffPer1;

            public byte rankEffPer2;

            public byte rankEffPer3;

            public uint flags;

            public uint contestWazaNo;
        }

        [Serializable]
        public class SheetYubiwohuru
        {
            public SheetYubiwohuru()
            {
            }

            public ushort[] wazaNos;
        }
    }
}
