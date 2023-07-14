using System;
using Dpr.Battle.View;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class BattleWaitCameraData : ScriptableObject
    {
        public BattleWaitCameraData.SheetWaitCameraData Item
        {
            get
            {
                return null;
            }
        }

        public BattleWaitCameraData()
        {
        }

        public BattleWaitCameraData.SheetWaitCameraData[] WaitCameraData;

        [Serializable]
        public class SheetWaitCameraData
        {
            public SheetWaitCameraData()
            {
            }

            public int Index;

            public string FileName;

            public float Speed;

            public bool BtlRuleS;

            public bool BtlRuleTrS;

            public bool BtlRuleTrD1;

            public bool BtlRuleTrD2;

            public bool BtlRuleM;

            public bool BtlRuleTrM;

            public bool BtlRuleL1;

            public bool BtlRuleL2;

            public bool BtlRuleL3;

            public bool BtlRuleL4;

            public bool BtlRuleL5;

            public bool BtlRuleL6;

            public bool BtlRuleL7;

            public bool BtlRuleL8;

            public bool BtlRuleF1;

            public bool BtlRuleF2;

            public bool BtlRuleF3;

            public bool BtlRuleF4;

            public bool BtlRuleC;

            public bool BtlRuleG1;

            public bool BtlRuleG2;

            public bool BtlRuleG3;

            public bool BtlRuleG4;

            public bool BtlRuleBTW;

            public bool BtlRuleJk1;

            public bool BtlRuleJk2;

            public bool BtlRuleSafari;

            public bool BtlRuleTutorial;

            public bool BtlRuleDemoCaputure;

            public WaitCameraTarget Target;

            public WaitCameraNode Node;

            public float SizeS;

            public float SizeM;

            public float SizeL;

            public bool CheckGround;

            public int Priority;

            public int[] ForbidNext;

            public bool DoFEnable;

            public float FarDepth;

            public float FocalLength;

            public float Distance;

            public WaitCameraDispPokeTra DispPokeTra;

            public bool DrawRangeEnable;

            public float FoV;

            public float Near;

            public int Far;

            public bool IsIndoor;

            public bool IsOutdoor;

            public bool useReflection;
        }
    }
}
