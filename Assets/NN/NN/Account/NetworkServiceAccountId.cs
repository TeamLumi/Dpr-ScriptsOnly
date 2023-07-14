using System;
using System.Runtime.InteropServices;

namespace nn.account
{
    public struct NetworkServiceAccountId : IEquatable<NetworkServiceAccountId>
    {
        public ulong id;

        public override string ToString()
        {
            return string.Format("{0:X}", id);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NetworkServiceAccountId)) { return false; }
            return Equals((NetworkServiceAccountId)obj);
        }
        public bool Equals(NetworkServiceAccountId other) { return this == other; }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(NetworkServiceAccountId lhs, NetworkServiceAccountId rhs)
        {
            return lhs.id == rhs.id;
        }
        public static bool operator !=(NetworkServiceAccountId lhs, NetworkServiceAccountId rhs)
        {
            return !(lhs == rhs);
        }
    }
}
