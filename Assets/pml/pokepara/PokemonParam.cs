using System;

namespace Pml.PokePara
{
    public sealed class PokemonParam : CoreParam
    {
        public PokemonParam()
        {
        }

        public PokemonParam(MonsNo monsno, ushort level, ulong id)
        {
        }

        public PokemonParam(InitialSpec spec)
        {
        }

        public PokemonParam(PokemonParam src)
        {
        }

        public PokemonParam(CoreParam src)
        {
        }

        public void Setup(InitialSpec spec)
        {
        }

        public void Serialize_Full(byte[] buffer)
        {
        }

        public void Serialize_Core(byte[] buffer)
        {
        }

        public void Deserialize_Full(byte[] serializedData)
        {
        }

        public void Deserialize_Core(byte[] serializedData)
        {
        }

        public void CopyFrom(PokemonParam pSrcParam)
        {
        }

        public string GetNoparseNickName()
        {
            return null;
        }

        public void Dump()
        {
        }

        private void CreateAndAttachCalcData()
        {
        }

        private void InitCalcData()
        {
        }

        public new const int DATASIZE = 344;

        private static byte[] sParamSerializeBuffer;
    }
}
