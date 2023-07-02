using System;
using System.Runtime.InteropServices;

namespace Pml.PokePara
{
    [StructLayout(LayoutKind.Sequential)]
    public class CoreDataHeader
    {
        public int SIZE;
        public uint personalRnd;
        public ushort _bitsA;
        public ushort checksum;
        public int bitsA0_sz;
        public int bitsA0_loc;
        public int bitsA1_sz;
        public int bitsA1_loc;
        public int bitsA2_sz;
        public int bitsA2_loc;
        public int bitsA0_mask;
        public int bitsA1_mask;
        public int bitsA2_mask;

        public bool PpFastMode
        {
            get { return (_bitsA & bitsA0_mask) != 0; }
            set { _bitsA = (ushort)((_bitsA & ~bitsA0_mask) | (value ? bitsA0_mask : 0)); }
        }

        public bool PppFastMode
        {
            get { return (_bitsA & bitsA1_mask) != 0; }
            set { _bitsA = (ushort)((_bitsA & ~bitsA1_mask) | (value ? bitsA1_mask : 0)); }
        }

        public bool FuseiTamagoFlag
        {
            get { return (_bitsA & bitsA2_mask) != 0; }
            set { _bitsA = (ushort)((_bitsA & ~bitsA2_mask) | (value ? bitsA2_mask : 0)); }
        }
    }
}
