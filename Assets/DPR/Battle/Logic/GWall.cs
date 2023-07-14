using System;

namespace Dpr.Battle.Logic
{
    public sealed class GWall
    {
        public GWall()
        {
        }

        public void CopyFrom(in GWall src)
        {
        }

        public void Setup(byte gaugeMax, byte gaugeInit, byte repairTurn)
        {
        }

        public void SetAppear()
        {
        }

        public bool IsAppeared()
        {
            return default(bool);
        }

        public bool IsActive()
        {
            return default(bool);
        }

        public bool IsBroken()
        {
            return default(bool);
        }

        public byte GetGauseMax()
        {
            return default(byte);
        }

        public byte GetGaugeNow()
        {
            return default(byte);
        }

        public byte GetGauseInit()
        {
            return default(byte);
        }

        public void InitGauge()
        {
        }

        public void SetGauge(byte value)
        {
        }

        public void AddGauge(byte value)
        {
        }

        public void SubGauge(byte value)
        {
        }

        public bool IsGaugeZero()
        {
            return default(bool);
        }

        public bool IsGaugeFull()
        {
            return default(bool);
        }

        public byte GetRepairTurnCount()
        {
            return default(byte);
        }

        public void DecrementRepairTurnCount()
        {
        }

        public void SetRepairTurnCountMax()
        {
        }

        public void DecrementRepairTurnCountMax()
        {
        }

        private bool m_isAppeared;

        private byte m_gaugeMax;

        private byte m_gaugeNow;

        private byte m_gaugeInit;

        private byte m_repairTurnCount;

        private byte m_repairTurnMax;
    }
}
