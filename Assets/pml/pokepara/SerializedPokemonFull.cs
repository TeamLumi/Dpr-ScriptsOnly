using System;
using UnityEngine;

namespace Pml.PokePara
{
    [Serializable]
    public struct SerializedPokemonFull
    {
        public void CopyFrom(in SerializedPokemonFull src)
        {
        }

        public static void Swap(ref SerializedPokemonFull lhs, ref SerializedPokemonFull rhs)
        {
        }

        public void CreateWorkIfNeed()
        {
        }

        [SerializeField]
        public byte[] buffer;
    }
}
