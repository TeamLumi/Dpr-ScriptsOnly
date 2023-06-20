using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class WaterSettings
    {
        [Serializable]
        public class SheetSettings : ScriptableObject
        {
            public GameObject ZoneIDs;

            public float PlaneElevation;

            public Color Color;

            public float UpScale;

            public float Attenuation;

            public float MaxDensity;

            public float Reflectivity;

            public float FresnelPower;

            public float SpecularIntensity;

            public float SpecularCosinePower;
        }

        public GameObject Settings;

        public object this[int index] => null;
    }
}
