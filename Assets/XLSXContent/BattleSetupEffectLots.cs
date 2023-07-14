using System;
using AttributeData;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class BattleSetupEffectLots : ScriptableObject
    {
        public BattleSetupEffectLots.SheetAttEffTable Item
        {
            get
            {
                return null;
            }
        }

        public BattleSetupEffectLots()
        {
        }

        public BattleSetupEffectLots.SheetAttEffTable[] AttEffTable;

        public BattleSetupEffectLots.SheetRuleEffTable[] RuleEffTable;

        public BattleSetupEffectLots.SheetArenaEffTable[] ArenaEffTable;

        [Serializable]
        public class SheetAttEffTable
        {
            public SheetAttEffTable()
            {
            }

            public MapAttributeEx AttributeEx;

            public ArenaID ArenaID;

            public EffectBattleID EffectID;

            public string SoundEventName;
        }

        [Serializable]
        public class SheetRuleEffTable
        {
            public SheetRuleEffTable()
            {
            }

            public BattleSetupEffectLot Rule;

            public BattleSetupEffectId BattleID;
        }

        [Serializable]
        public class SheetArenaEffTable
        {
            public SheetArenaEffTable()
            {
            }

            public ArenaID ArenaID;

            public EffectBattleID[] EffectID;
        }
    }
}
