using System;
using System.Runtime.InteropServices;

namespace nn.account
{
    public struct Uid : IEquatable<Uid>
    {
        public static Uid Invalid { get { return new Uid(); } }

        public ulong _data0;
        public ulong _data1;

        public bool IsValid()
        {
            return (_data0 != 0) || (_data1 != 0);
        }

        public override string ToString()
        {
            return string.Format("{0,0:X16}{1,0:X16}", _data0, _data1);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Uid)) { return false; }
            return Equals((Uid)obj);
        }
        public bool Equals(Uid other) { return this == other; }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(Uid lhs, Uid rhs) { return lhs._data0 == rhs._data0 && lhs._data1 == rhs._data1; }
        public static bool operator !=(Uid lhs, Uid rhs) { return !(lhs == rhs); }
    }
}
