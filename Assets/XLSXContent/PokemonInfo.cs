using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class PokemonInfo : ScriptableObject
    {
        public SheetCatalog[] Catalog;

        [Serializable]
        public class SheetCatalog
        {
            public SheetCatalog()
            {
                // Constructor logic here
            }

            public int UniqueID;
            public int No;
            public int SinnohNo;
            public int MonsNo;
            public int FormNo;
            public int Sex;
            public int Rare;
            public string AssetBundleName;
            public float BattleScale;
            public float ContestScale;
            public int ContestSize;
            public float FieldScale;
            public float FieldChikaScale;
            public float StatueScale;
            public float FieldWalkingScale;
            public float FieldFureaiScale;
            public float MenuScale;
            public string ModelMotion;
            public Vector3 ModelOffset;
            public Vector3 ModelRotationAngle;
            public float DistributionScale;
            public string DistributionModelMotion;
            public Vector3 DistributionModelOffset;
            public Vector3 DistributionModelRotationAngle;
            public float VoiceScale;
            public string VoiceModelMotion;
            public Vector3 VoiceModelOffset;
            public Vector3 VoiceModelRotationAngle;
            public Vector3 CenterPointOffset;
            public Vector2 RotationLimitAngle;
            public float StatusScale;
            public string StatusModelMotion;
            public Vector3 StatusModelOffset;
            public Vector3 StatusModelRotationAngle;
            public float BoxScale;
            public string BoxModelMotion;
            public Vector3 BoxModelOffset;
            public Vector3 BoxModelRotationAngle;
            public float CompareScale;
            public string CompareModelMotion;
            public Vector3 CompareModelOffset;
            public Vector3 CompareModelRotationAngle;
            public float BrakeStart;
            public float BrakeEnd;
            public float WalkSpeed;
            public float RunSpeed;
            public float WalkStart;
            public float RunStart;
            public float BodySize;
            public float AppearLimit;
            public int MoveType;
            public bool GroundEffect;
            public bool Waitmoving;
            public int BattleAjustHeight;
        }
        public SheetCatalog GetItem(int index)
        {
            if (index < Catalog.Length)
            {
                return Catalog[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
