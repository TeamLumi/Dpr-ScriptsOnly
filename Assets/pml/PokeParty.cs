using System;
using Pml.PokePara;

namespace Pml
{
    public sealed class PokeParty
    {
        public PokeParty()
        {
        }

        public bool AddMember(PokemonParam pp)
        {
            return default(bool);
        }

        public void ReplaceMember(uint idx, PokemonParam pp)
        {
        }

        public void RemoveMember(uint idx)
        {
        }

        public void ExchangePosition(byte pos1, byte pos2)
        {
        }

        public PokemonParam GetMemberPointer(uint idx)
        {
            return null;
        }

        public PokemonParam GetMemberPointerConst(uint idx)
        {
            return null;
        }

        public uint GetMemberCount()
        {
            return default(uint);
        }

        public void SetMemberCount(uint count)
        {
        }

        public uint GetMemberIndex(PokemonParam pokeParam)
        {
            return default(uint);
        }

        public uint GetMemberCountEx(PokeParty.CountType type)
        {
            return default(uint);
        }

        public uint GetMemberCountEx(PokeParty.CountType type, byte pass_idx_bit)
        {
            return default(uint);
        }

        public uint GetMemberTopIndex(PokeParty.SearchType type)
        {
            return default(uint);
        }

        public bool CheckPokeExist(MonsNo monsno)
        {
            return default(bool);
        }

        public bool IsFull()
        {
            return default(bool);
        }

        public void CopyFrom(PokeParty src)
        {
        }

        public void Clear()
        {
        }

        public void SerializeFull(ref SavePokeParty save)
        {
        }

        public void DeserializeFull(ref SavePokeParty save)
        {
        }

        public bool CheckPokerusExist()
        {
            return default(bool);
        }

        public bool PokerusCatchCheck()
        {
            return default(bool);
        }

        public bool PokerusInfectionCheck()
        {
            return default(bool);
        }

        public void DecreasePokerusDayCount(int passed_day_count)
        {
        }

        public void RecoverAll()
        {
        }

        public void SetMarkingIndex(uint pos)
        {
        }

        public uint GetMarkingIndex()
        {
            return default(uint);
        }

        public bool CanTrade()
        {
            return default(bool);
        }

        public bool CanTradeMember(uint idx)
        {
            return default(bool);
        }

        private void Dump()
        {
        }

        private void scootOver()
        {
        }

        private void ClearMarkingIndex()
        {
        }

        public const int MAX_MEMBERS = 6;

        public const int MEMBER_INDEX_ERROR = 6;

        private PokemonParam[] m_member;

        private uint m_memberCount;

        private byte markingIndex;

        public enum CountType
        {
            ALL,
            BATTLE_ENABLE,
            NOT_EGG,
            ONLY_LEGAL_EGG,
            ONLY_ILLEGAL_EGG,
            BOTH_EGG
        }

        public enum SearchType
        {
            BATTLE_ENABLE,
            NOT_EGG
        }
    }
}
