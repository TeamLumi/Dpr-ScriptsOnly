using System;

namespace Dpr.Battle.Logic
{
    public sealed class PartyDesc
    {
        public static void Clear(PartyDesc desc)
        {
        }

        public static void Copy(PartyDesc dest, in PartyDesc src)
        {
        }

        public PartyDesc()
        {
        }

        public PokeDesc[] pokeDesc;
    }
}
