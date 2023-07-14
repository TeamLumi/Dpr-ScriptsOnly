using System;
using Pml;
using Pml.Personal;

namespace Dpr.Battle.Logic
{
    public class RaidBossDesc
    {
        public void CopyFrom(RaidBossDesc src)
        {
        }

        public static void Copy(RaidBossDesc pDesc, in RaidBossDesc src)
        {
        }

        public static void SetDefault(RaidBossDesc pDesc, MonsNo monsno, ushort formno, byte grade)
        {
        }

        public RaidBossDesc()
        {
        }

        public float hpCoef;

        public byte gWazaFrequency;

        public byte actNum;

        public byte gWallGaugeMax;

        public byte gWallGaugeInit;

        public byte gWallRepairTurn;

        public byte[] angryHPThreshold;

        public WazaNo[] angryWazaNo;

        public RaidBossAngryWazaTiming[] angryWazaTimming;
    }
}
