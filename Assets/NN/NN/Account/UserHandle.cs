using System;
using System.Runtime.InteropServices;

namespace nn.account
{
    public struct UserHandle
    {
        public ulong _data0;
        public ulong _data1;
        public ulong _context;

        public override string ToString()
        {
            return string.Format("{0,0:X16}{1,0:X16}_{2,0:X16}", _data0, _data1, _context);
        }
    }
}
