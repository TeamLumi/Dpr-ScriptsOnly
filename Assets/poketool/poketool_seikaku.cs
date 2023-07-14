using System;
using Pml.PokePara;

namespace poketool.seikaku
{
    public static class poketool_seikaku
    {
        public static poketool_seikaku.Seikaku2nd GetSeikaku2nd(CoreParam poke)
        {
            return poketool_seikaku.Seikaku2nd.TABERU;
        }

        private static poketool_seikaku.Seikaku2nd GetSeikaku2nd(uint personalRand, uint talent_hp, uint talent_atk, uint talent_def, uint talent_spatk, uint talent_spdef, uint talent_agi)
        {
            return poketool_seikaku.Seikaku2nd.TABERU;
        }

        public static PowerID GetPowerBySeikaku2nd(poketool_seikaku.Seikaku2nd seikaku2nd)
        {
            return PowerID.HP;
        }

        private static readonly PowerID[] s_power_priority;

        private static readonly uint[][] s_priority_array;

        public enum Seikaku2nd
        {
            TABERU,
            HIRUNE,
            INEMURI,
            TIRAKASU,
            NONBIRI,
            TIKARAZIMAN,
            ABARERU,
            OKORIPPOI,
            KENKA,
            TINOKE,
            ZYOUBU,
            UTAREDUYOI,
            NEBARIDUYOI,
            SINBOUDUYOI,
            GAMANDUYOI,
            KAKEKKO,
            MONOOTO,
            OTTYOKOTYOI,
            OTYOUSIMONO,
            NIGERU,
            KOUKISIN,
            ITAZURA,
            NUKEMEGANAI,
            KANGAEGOTO,
            KITYOUMEN,
            KIGATUYOI,
            MIEPPARI,
            MAKENKI,
            MAKEZUGIRAI,
            GOUZYOU,
            NUM
        }
    }
}
