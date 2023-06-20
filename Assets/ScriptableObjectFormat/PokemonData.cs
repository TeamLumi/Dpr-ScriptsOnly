using System;
using UnityEngine;

namespace ScriptableObjectFormat
{
    [Serializable]
    public class PokemonData : ScriptableObject
    {
        public PokemonData()
        {
        }

        public PersonalData[] Personal;
        public ModelData[] Model;
        public PokemonWalkingDatas WalkingData;

        [Serializable]
        public class PersonalData
        {
            public PersonalData()
            {
            }

            public string ID;
            public int Index;
            public string Name;
            public int Variation;
            public string Form;
            public string Attribute1;
            public string Attribute2;
            public string Class;
        }

        [Serializable]
        public class ModelData
        {
            public ModelData()
            {
            }

            public string ID;
            public int Index;
            public string Name;
            public int FormIndex;
            public string Form;
            public string Symbol;
            public string AssetBundleName;
            public string Variation;
            public double Scale1;
            public double Scale2;
            public Vector3 Offset;
            public int ModelHeight;
        }
    }
}
