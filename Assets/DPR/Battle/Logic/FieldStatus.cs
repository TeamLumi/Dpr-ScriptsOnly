using System;
using Pml;
using static UnityEngine.ParticleSystem;

namespace Dpr.Battle.Logic
{
    public sealed class FieldStatus
    {
        public FieldStatus()
        {
        }

        public void Init()
        {
        }

        private void initWork()
        {
        }

        public void CopyFrom(in FieldStatus src)
        {
        }

        public BtlWeather GetWeather()
        {
            return BtlWeather.BTL_WEATHER_NONE;
        }

        public uint GetWeatherPassedTurn()
        {
            return default(uint);
        }

        public uint GetWeatherRemainingTurn()
        {
            return default(uint);
        }

        public byte GetWeatherCausePokeID()
        {
            return default(byte);
        }

        public uint GetWeatherWholeTurn()
        {
            return default(uint);
        }

        public uint GetWeatherTurnUpCount()
        {
            return default(uint);
        }

        public void SetWeather(BtlWeather weather, ushort turn, ushort turnUpCount, byte causePokeID)
        {
        }

        public void EndWeather()
        {
        }

        public BtlWeather TurnCheckWeather()
        {
            return BtlWeather.BTL_WEATHER_NONE;
        }

        public bool AddEffect(EffectType effect, in BTL_SICKCONT cont)
        {
            return default(bool);
        }

        private bool addEffectCore(EffectType effect, in BTL_SICKCONT cont, ushort sub_param)
        {
            return default(bool);
        }

        public bool RemoveEffect(EffectType effect)
        {
            return default(bool);
        }

        public bool AddDependPoke(EffectType effect, byte pokeID)
        {
            return default(bool);
        }

        public bool RemoveDependPoke(EffectType effect, byte pokeID)
        {
            return default(bool);
        }

        public bool IsDependPoke(EffectType effect, byte pokeID)
        {
            return default(bool);
        }

        public bool CheckFuin(in MainModule mainModule, POKECON pokeCon, BTL_POKEPARAM attacker, WazaNo waza)
        {
            return default(bool);
        }

        public bool IncTurnCount(EffectType effect)
        {
            return default(bool);
        }

        public bool CheckEffect(EffectType effect)
        {
            return default(bool);
        }

        public bool CheckEffect(EffectType effect, ushort subParam)
        {
            return default(bool);
        }

        public uint CheckRemainingTurn(EffectType effect)
        {
            return default(uint);
        }

        public uint GetPassedTurn(EffectType effect)
        {
            return default(uint);
        }

        public uint GetWholeTurn(EffectType effect)
        {
            return default(uint);
        }

        public byte GetDependPokeID(EffectType effect)
        {
            return default(byte);
        }

        private void clearFactorWork(EffectType effect)
        {
        }

        public uint GetDependPokeCount(EffectType effect)
        {
            return default(uint);
        }

        public bool IsKagakuhenkaGasEffective()
        {
            return default(bool);
        }

        public bool CheckTokuseiEffectiveOnKagakuhenkaGas(TokuseiNo tokusei)
        {
            return default(bool);
        }

        public bool ChangeGround(byte ground, BTL_SICKCONT cont)
        {
            return default(bool);
        }

        public byte GetGround()
        {
            return default(byte);
        }

        public uint GetGroundPassedTurn()
        {
            return default(uint);
        }

        public uint GetGroundRemainingTurn()
        {
            return default(uint);
        }

        public uint GetGroundWholeTurn()
        {
            return default(uint);
        }

        public uint GetGroundTurnUpCount()
        {
            return default(uint);
        }

        public byte GetGroundCausePokeID()
        {
            return default(byte);
        }

        private const int TURN_MAX = 16;

        private const int DEPEND_POKE_NUM_MAX = 5;

        private FieldStatus.Data m_data;

        public delegate void TurnCheckCallback(EffectType UnnamedParameter, object UnnamedParameter2);

        private class Data
        {
            public void CopyFrom(FieldStatus.Data src)
            {
            }

            public Data()
            {
            }

            public BtlWeather weather;

            public uint weatherTurn;

            public uint weatherTurnUpCount;

            public uint weatherTurnCount;

            public byte weatherCausePokeID;

            public BtlGround currentGround;

            public BTL_SICKCONT[] cont;

            public uint[] turnCount;

            public uint[][] dependPokeID;

            public uint[] dependPokeCount;

            public bool[] enableFlag;

            public ushort[] subParam;
        }
    }
}
