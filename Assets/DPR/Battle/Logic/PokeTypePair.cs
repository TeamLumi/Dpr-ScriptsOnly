using System;

namespace Dpr.Battle.Logic
{
    public struct PokeTypePair
    {
        //public PokeTypePair(ushort value)
        //{
        //}

        public static PokeTypePair Make(byte type1, byte type2, byte type_ex)
        {
            return default(PokeTypePair);
        }

        public static PokeTypePair MakePure(byte type)
        {
            return default(PokeTypePair);
        }

        public static byte GetType1(PokeTypePair pair)
        {
            return default(byte);
        }

        public static byte GetType2(PokeTypePair pair)
        {
            return default(byte);
        }

        public static byte GetTypeEx(PokeTypePair pair)
        {
            return default(byte);
        }

        //public static void Split(PokeTypePair pair, out byte type1, out byte type2, out byte typeEx)
        //{
        //}

        public static bool IsMatch(PokeTypePair pair, byte type)
        {
            return default(bool);
        }

        public static bool IsPure(PokeTypePair pair, bool includeExType = true)
        {
            return default(bool);
        }

        public static PokeTypePair Replace(PokeTypePair pair, byte targetType, byte newType)
        {
            return default(PokeTypePair);
        }

        public static bool IsAnyTypeExist(PokeTypePair pair)
        {
            return default(bool);
        }

        public static implicit operator ushort(PokeTypePair pair)
        {
            return default(ushort);
        }

        public static explicit operator PokeTypePair(ushort value)
        {
            return default(PokeTypePair);
        }

        public ushort value;
    }
}
