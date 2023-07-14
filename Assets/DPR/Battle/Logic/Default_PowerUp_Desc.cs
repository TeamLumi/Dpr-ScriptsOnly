using System;
using DG.Tweening;
using System.Security.Cryptography;

namespace Dpr.Battle.Logic
{
    public static class DEFAULT_POWERUP_DESC
    {
        public static void Clear(DefaultPowerUpDesc desc)
        {
        }

        public static void Copy(DefaultPowerUpDesc dest, in DefaultPowerUpDesc src)
        {
        }

        public static uint GetRankUpParamCount(in DefaultPowerUpDesc desc)
        {
            return default(uint);
        }

        public static byte GetMaxRankUpValue(in DefaultPowerUpDesc desc)
        {
            return default(byte);
        }
    }
}
