using System;
using DG.Tweening;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Dpr.Battle.Logic
{
    public sealed class PokeDesc
    {
        public static void Clear(PokeDesc desc)
        {
        }

        public static void Copy(PokeDesc dest, in PokeDesc src)
        {
        }

        public PokeDesc()
        {
        }

        public DefaultPowerUpDesc defaultPowerUpDesc;

        public bool isGEnableByNPC;
    }
}
