using System;
using UnityEngine;

namespace Pml.PokePara
{
    [Serializable]
    public struct SavePokeParty
    {
        public void Serialize_Full(PokeParty party)
        {
        }

        public void Deserialize_Full(PokeParty party)
        {
        }

        public void CreateWorkIfNeed()
        {
        }

        public void Clear()
        {
        }

        [SerializeField]
        private SerializedPokemonFull[] members;

        [SerializeField]
        private byte memberCount;

        [SerializeField]
        private byte markingIndex;
    }
}
