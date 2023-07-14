using System;
using Pml;
using Pml.Personal;

namespace Dpr.Battle.Logic
{
    public class RaidBossParam
    {
        public RaidBossParam()
        {
        }

        public void CopyFrom(in RaidBossParam src)
        {
        }

        public void Setup(in RaidBossParam.SetupParam param)
        {
        }

        public float GetHPCoef()
        {
            return default(float);
        }

        public GWall GetGWallConst()
        {
            return null;
        }

        public GWall GetGWall()
        {
            return null;
        }

        public byte GetGrade()
        {
            return default(byte);
        }

        public byte GetReinforceTurn()
        {
            return default(byte);
        }

        public void SetReinforceTurn(byte turn)
        {
        }

        public void DecReinforceTurn()
        {
        }

        public byte GetActionNum()
        {
            return default(byte);
        }

        public byte GetGWazaUseFrequency()
        {
            return default(byte);
        }

        public bool IsOnGWazaUseTurn()
        {
            return default(bool);
        }

        public void DecGWazaUseTurn()
        {
        }

        public void SetGWazaUsed()
        {
        }

        public void ResetGWazaUseSchedule(byte reUseTurn)
        {
        }

        public byte GetAngryHPThreshold()
        {
            return default(byte);
        }

        public void IncAngryLevel()
        {
        }

        public bool IsAngryLevelMax()
        {
            return default(bool);
        }

        public bool IsAngry()
        {
            return default(bool);
        }

        public WazaNo GetAngryWaza()
        {
            return WazaNo.NULL;
        }

        public RaidBossAngryWazaTiming GetAngryWazaTiming()
        {
            return RaidBossAngryWazaTiming.NONE;
        }

        private GWall m_gWall;

        private RaidBossDesc m_desc;

        private byte m_grade;

        private byte m_reinforceTurn;

        private byte m_angryLevel;

        private byte m_gWazaUseTurn;

        private bool m_gWazaUsed;

        public class SetupParam
        {
            public SetupParam()
            {
            }

            public byte grade;

            public RaidBossDesc pDesc;
        }
    }
}
