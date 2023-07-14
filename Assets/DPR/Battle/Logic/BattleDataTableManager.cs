using System;
using AttributeData;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.Battle.Logic
{
    public sealed class BattleDataTableManager
    {
        public static BattleDataTableManager Instance
        {
            get
            {
                return null;
            }
        }

        public BattleDataTable BattleDataTable
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public BattleDefaultPlacementData BattleDefaultPlacementData
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public BattleWaitCameraData BattleWaitCameraData
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public BattleSetupEffectLots BattleSetupEffectLots
        {
            get
            {
                return null;
            }
            private set
            {
            }
        }

        public bool IsInitialized
        {
            get
            {
                return default(bool);
            }
            private set
            {
            }
        }

        private bool IsABAppended
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public bool AppendAssetBundleRequests()
        {
            return default(bool);
        }

        public bool OnDispatchRequests(RequestEventType eventType, string name, UnityEngine.Object asset)
        {
            return default(bool);
        }

        private bool IsLoaded
        {
            get
            {
                return default(bool);
            }
        }

        public void OnAfterLoadAll()
        {
        }

        private static void OnAfterLoadAll_Update(float deltaTime)
        {
        }

        public static BattleSetupEffectLots.SheetArenaEffTable GetArenaEff(ArenaID arenaID)
        {
            return null;
        }

        public static BattleSetupEffectLots.SheetAttEffTable GetAttEff(MapAttributeEx mapAttributeEx, ArenaID arenaID)
        {
            return null;
        }

        public static BattleSetupEffectLots.SheetRuleEffTable GetRuleEff(BattleSetupEffectLot lot)
        {
            return null;
        }

        public BattleDataTableManager()
        {
        }

        private static BattleDataTableManager s_Instance;

        private static readonly string[] AB_NAMES;

        public BattleSetupEffectLot lot;
	}
}
