using System;

namespace nn
{
    public struct Result : IEquatable<Result>
    {
        public const int ModuleBitsOffset = 0;
        public const int ModuleBitsCount = 9;
        public const int ModuleBitsMask = 0x1FF;
        public const int DescriptionBitsOffset = ModuleBitsOffset + ModuleBitsCount;
        public const int DescriptionBitsCount = 13;
        public const int DescriptionBitsMask = 0x1FFF;

        public uint innerValue;

        public Result(int module, int description)
        {
            innerValue = (uint)(module | (description << DescriptionBitsOffset));
        }

        public bool IsSuccess()
        {
            return (innerValue == 0);
        }

        public void abortUnlessSuccess()
        {
            if (!IsSuccess())
            {
                Nn.Abort(ToString());
            }
        }

        public int GetModule()
        {
            return ((int)innerValue >> ModuleBitsOffset) & ModuleBitsMask;
        }

        public int GetDescription()
        {
            return ((int)innerValue >> DescriptionBitsOffset) & DescriptionBitsMask;
        }

        public override string ToString()
        {
            return string.Format("0x{0,0:X8} Module:{1} Description:{2}",
                innerValue, GetModule(), GetDescription());
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Result)) { return false; }
            return Equals((Result)obj);
        }
        public bool Equals(Result other) { return this == other; }
        public override int GetHashCode() { return base.GetHashCode(); }
        public static bool operator ==(Result lhs, Result rhs) { return lhs.innerValue == rhs.innerValue; }
        public static bool operator !=(Result lhs, Result rhs) { return !(lhs == rhs); }
    }

    public struct ErrorRange
    {
        private int _module;
        private int _descriptionBegin;
        private int _descriptionEnd;

        internal ErrorRange(int module, int descriptionBegin, int descriptionEnd)
        {
            _module = module;
            _descriptionBegin = descriptionBegin;
            _descriptionEnd = descriptionEnd;
        }

        public int Module { get { return _module; } }
        public int DescriptionBegin { get { return _descriptionBegin; } }
        public int DescriptionEnd { get { return _descriptionEnd; } }

        public bool Includes(Result result)
        {
            if (result.GetModule() != Module) { return false; }
            int description = result.GetDescription();
            return (DescriptionBegin <= description) && (description < DescriptionEnd);
        }
    }
}
