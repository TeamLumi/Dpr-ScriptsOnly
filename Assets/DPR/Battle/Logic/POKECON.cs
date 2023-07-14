using System;
using System.Runtime.InteropServices.ComTypes;
using Pml;
using Pml.PokePara;
using static UnityEngine.ParticleSystem;

namespace Dpr.Battle.Logic
{
    public sealed class POKECON
    {
        public static void InitSystem()
        {
        }

        public static void QuitSystem()
        {
        }

        public POKECON(MainModule mainModule, FieldStatus fieldStatus)
        {
        }

        public void Dispose()
        {
        }

        public void Clear()
        {
        }

        private void storeAllPokeParam()
        {
        }

        private void storePokeParam(byte pokeID)
        {
        }

        private void activatePokeParam(byte pokeID)
        {
        }
        public void CopyFrom(in POKECON src)
        {
        }

        public void SetParty(byte clientID, PokeParty srcParty, in PartyDesc partyDesc, MyStatus playerData)
        {
        }

        private void addPokeParam(byte clientID, byte pokeID, PokemonParam srcParam, in DefaultPowerUpDesc defaultPowerUpDesc, MyStatus playerData)
        {
        }

        private void setupPokeParam(BTL_POKEPARAM pokeParam, byte pokeID, PokemonParam srcParam, in DefaultPowerUpDesc defaultPowerUpDesc, MyStatus playerData)
        {
        }

        private bool checkForceGEnable(PokemonParam pPoke)
        {
            return default(bool);
        }

        private void updateIllusionTarget(byte clientID)
        {
        }

        public BTL_PARTY GetPartyData(uint clientID)
        {
            return null;
        }

        public BTL_PARTY GetPartyDataConst(uint clientID)
        {
            return null;
        }

        public BTL_POKEPARAM GetClientPokeDataConst(byte clientID, byte memberIdx)
        {
            return null;
        }

        public BTL_POKEPARAM GetPokeParam(byte pokeID)
        {
            return null;
        }

        public BTL_POKEPARAM GetPokeParamConst(byte pokeID)
        {
            return null;
        }

        public bool IsExistPokemon(byte pokeID)
        {
            return default(bool);
        }

        public BTL_POKEPARAM GetViewSrcPokeParam(byte pokeID)
        {
            return null;
        }

        public void ConvertToPokeParty(PokeParty pDstParty, byte clientID, bool fDefaultForm)
        {
        }

        public void ConvertToPokePartyByStartingOrder(PokeParty pDstParty, byte clientID, bool[] fightPokeIdx)
        {
        }

        private void convertToPokeParamAndAddPokeParty(PokeParty pDstParty, BTL_PARTY pBtlParty, byte memberIdx)
        {
        }

        public int FindPokemon(byte clientID, byte pokeID)
        {
            return default(int);
        }

        public BTL_POKEPARAM GetFrontPokeData(BtlPokePos pos)
        {
            return null;
        }

        public BTL_POKEPARAM GetFrontPokeDataConst(BtlPokePos pos)
        {
            return null;
        }

        public byte GetFrontPokeID(BtlPokePos pos)
        {
            return default(byte);
        }

        public BTL_POKEPARAM GetClientPokeData(byte clientID, byte posIdx)
        {
            return null;
        }

        private readonly MainModule m_mainModule;

        private BTL_PARTY[] m_party;

        private BTL_POKEPARAM[] m_activePokeParam;

        private BTL_POKEPARAM[] m_storedPokeParam;

        private static PokeParty s_tmpPokeParty;
    }
}
