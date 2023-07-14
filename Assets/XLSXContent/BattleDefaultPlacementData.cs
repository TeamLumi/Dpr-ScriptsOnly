using System;
using System.Drawing;
using Dpr.Battle.Logic;
using Dpr.SequenceEditor;
using Pml.PokePara;
using UnityEngine;
using Size = Pml.PokePara.Size;

namespace XLSXContent
{
    [Serializable]
    public class BattleDefaultPlacementData : ScriptableObject
    {
        public BattleDefaultPlacementData.SheetDefaultCharaPlacementData Item
        {
            get
            {
                return null;
            }
        }

        public BattleDefaultPlacementData()
        {
        }

        public BattleDefaultPlacementData.SheetDefaultCharaPlacementData[] DefaultCharaPlacementData;

        public BattleDefaultPlacementData.SheetDefaultCameraPlacementData[] DefaultCameraPlacementData;

        [Serializable]
        public class SheetDefaultCharaPlacementData
        {
            public SheetDefaultCharaPlacementData()
            {
            }

            public BtlRule BtlRule;

            public BtlvPos BtlvPos;

            public Size Size;

            public Vector3 PokePos;

            public Vector3 TrainerPos;

            public int RotY;

            public SEQ_DEF_DEFAULT_PLACEMENT UseSituation;
        }

        [Serializable]
        public class SheetDefaultCameraPlacementData
        {
            public SheetDefaultCameraPlacementData()
            {
            }

            public BtlRule BtlRule;

            public Size PokeSizeP;

            public Size PokeSizeE;

            public Vector3 MainCamPos;

            public Vector3 MainCamRot;

            public float MainCamNear;

            public float MainCamFar;

            public float MainCamFov;

            public Vector3 SubCamPos;

            public Vector3 SubCamRot;

            public float SubCamNear;

            public float SubCamFar;

            public float SubCamFov;
        }
    }
}
