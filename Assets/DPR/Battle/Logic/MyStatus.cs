using System;
using DPData;
using Dpr.Message;
using Pml;
using Pml.PokePara;

namespace Dpr.Battle.Logic
{
    public class MyStatus
    {
        public MyStatus()
        {
        }

        public void Deserialize(in MYSTATUS status)
        {
        }

        public void Deserialize(in MYSTATUS_COMM status)
        {
        }

        public void CopyFrom(MyStatus src)
        {
        }

        public string GetNameString()
        {
            return null;
        }

        public Sex GetSex()
        {
            return Sex.MALE;
        }

        public int GetHatVariation()
        {
            return default(int);
        }

        public int GetShoesVariation()
        {
            return default(int);
        }

        public MessageEnumData.MsgLangId GetPokeLanguageId()
        {
            return (MessageEnumData.MsgLangId)0;
        }

        public bool IsMyPokemon(CoreParam poke)
        {
            return default(bool);
        }

        public string GetModelID()
        {
            return null;
        }

        public int GetColorID()
        {
            return default(int);
        }

        private Sex _sex
        {
            get
            {
                return Sex.MALE;
            }
        }

        public bool HasGBand()
        {
            return default(bool);
        }

        public void SetCyclingRoad()
        {
        }

        //public static void GetParamFromSysFlag(out byte hat, out byte shoes)
        //{
        //}

        public string name;

        public bool sex;

        public MessageEnumData.MsgLangId lang;

        public uint id;

        public byte fashion;

        public byte body_type;

        public byte hat;

        public byte shoes;
    }
}
