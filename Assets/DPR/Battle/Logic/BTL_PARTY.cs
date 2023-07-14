using System;

namespace Dpr.Battle.Logic
{
    public sealed class BTL_PARTY
    {
        public BTL_PARTY()
        {
        }

        public void Dispose()
        {
        }

        public void Initialize()
        {
        }

        public void CopyFrom(in BTL_PARTY src)
        {
        }

        public void AddMember(BTL_POKEPARAM member)
        {
        }

        public void MoveAlivePokeToFirst()
        {
        }

        public void MoveLastMember(byte idx)
        {
        }

        public byte GetMemberCount()
        {
            return default(byte);
        }

        public byte GetAliveMemberCount()
        {
            return default(byte);
        }

        public byte GetAliveMemberCountRear(byte startIdx)
        {
            return default(byte);
        }

        public byte GetDeadMemberCount()
        {
            return default(byte);
        }

        public bool IsFull()
        {
            return default(bool);
        }

        public BTL_POKEPARAM GetMemberData(byte idx)
        {
            return null;
        }

        public BTL_POKEPARAM GetMemberDataConst(byte idx)
        {
            return null;
        }

        public void SwapMembers(byte idx1, byte idx2)
        {
        }

        public int FindMember(BTL_POKEPARAM param)
        {
            return default(int);
        }

        public int FindMemberByPokeID(byte pokeID)
        {
            return default(int);
        }

        public BTL_POKEPARAM GetAliveTopMember()
        {
            return null;
        }

        public byte GetMemberIndex(byte pokeID)
        {
            return default(byte);
        }

        public byte GetIllusionTargetMemberIndex()
        {
            return default(byte);
        }

        public byte GetTotalKillCount()
        {
            return default(byte);
        }

        private BTL_POKEPARAM[] m_pMember;

        private byte m_memberCount;
    }
}
