using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class FieldWazaCutInParam : ScriptableObject
    {
        public FieldWazaCutInParam()
        {

        }

        public SheetCommonParam[] CommonParam;

        [Serializable]
        public class SheetCommonParam
        {
            public float param;
        }

        public SheetPokemonParam[] PokemonParam;

        [Serializable]
        public class SheetPokemonParam
        {
            public int UniqueID;

            public float ModelScale;

            public string ModelMotion;

            public Vector3 ModelOffset;

            public Vector3 ModelRotationAngle;
        }
    }
}
