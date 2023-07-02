using System;

namespace SmartPoint.AssetAssistant
{
    [Serializable]
    public struct RecordedHash
    {
        public uint u0;
        public uint u1;
        public uint u2;
        public uint u3;

        public RecordedHash(uint u0, uint u1, uint u2, uint u3)
        {
            this.u0 = u0;
            this.u1 = u1;
            this.u2 = u2;
            this.u3 = u3;
        }

        private static uint SwapEndian(uint x)
        {
            return ((x >> 24) & 0x000000FF) | ((x >> 8) & 0x0000FF00) | ((x << 8) & 0x00FF0000) | ((x << 24) & 0xFF000000);
        }

        public static RecordedHash Parse(string hashString)
        {
            RecordedHash rec = new RecordedHash();
            if (!string.IsNullOrEmpty(hashString))
            {
                int strlen = hashString.Length;
                int len = Math.Min(8, strlen);
                var hashInt = Convert.ToUInt32(hashString.Substring(0, len));
                rec.u0 = SwapEndian(hashInt);
                strlen -= len;
                len = Math.Min(8, strlen);
                hashInt = Convert.ToUInt32(hashString.Substring(8, len));
                rec.u1 = SwapEndian(hashInt);
                strlen -= len;
                len = Math.Min(8, strlen);
                hashInt = Convert.ToUInt32(hashString.Substring(16, len));
                rec.u2 = SwapEndian(hashInt);
                strlen -= len;
                len = Math.Min(8, strlen);
                hashInt = Convert.ToUInt32(hashString.Substring(24, len));
                rec.u3 = SwapEndian(hashInt);
            }
            return rec;
        }

        public bool isValid
        {
            get => (u0 > 0 || u1 > 0 || u2 > 0 || u3 > 0);
        }

        public override string ToString()
        {
            return string.Format("{0:X4}", u0, u1, u2, u3);
        }

        public override int GetHashCode()
        {
            return u0.GetHashCode() ^ u1.GetHashCode() ^ u2.GetHashCode() ^ u3.GetHashCode();
        }

        public override bool Equals(object reference) => new bool();

        public static bool operator ==(RecordedHash lhs, RecordedHash rhs) => new bool();

        public static bool operator !=(RecordedHash lhs, RecordedHash rhs) => new bool();
    }
}