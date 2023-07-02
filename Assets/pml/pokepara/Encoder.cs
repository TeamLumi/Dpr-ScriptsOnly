using System;

namespace Pml.PokePara
{
    public class Encoder
    {
        public static ushort CalcChecksum(byte[] data, uint dataSize)
        {
            uint size = dataSize >> 1;
            if (size == 0)
            {
                return 0;
            }

            ushort checksum = 0;
            long offset = 0;
            long counter = ((long)size & 1) - (long)size;

            while (counter != 0)
            {
                ushort value1 = BitConverter.ToUInt16(data, (int)offset);
                ushort value2 = BitConverter.ToUInt16(data, (int)(offset + 2));
                checksum += (ushort)(value1 + value2);
                offset += 4;
                counter += 2;
            }

            if ((size & 1) != 0)
            {
                ushort value = BitConverter.ToUInt16(data, (int)offset);
                checksum += value;
            }

            return checksum;
        }

        public static void Encode(byte[] data, uint dataSize, uint key)
        {
            ulong size = (ulong)(dataSize >> 1);
            if (size != 0)
            {
                for (ulong i = 0; i < size; i++)
                {
                    key = key * 0x41c64e6d + 0x6073;
                    ushort value = BitConverter.ToUInt16(data, (int)(i * 2));
                    value = (ushort)(value ^ (ushort)(key >> 0x10));
                    byte[] bytes = BitConverter.GetBytes(value);
                    Buffer.BlockCopy(bytes, 0, data, (int)(i * 2), bytes.Length);
                }
            }
        }

        public static ushort CalcNextRandCode(ref uint code)
        {
            code = code * 0x41c64e6d + 0x6073;
            return (ushort)(code >> 0x10);
        }

        public static void Decode(byte[] data, uint dataSize, uint key)
        {
            ulong size = (ulong)(dataSize >> 1);
            if (size != 0)
            {
                for (ulong i = 0; i < size; i++)
                {
                    key = key * 0x41c64e6d + 0x6073;
                    ushort value = BitConverter.ToUInt16(data, (int)(i * 2));
                    value = (ushort)(value ^ (ushort)(key >> 0x10));
                    byte[] bytes = BitConverter.GetBytes(value);
                    Buffer.BlockCopy(bytes, 0, data, (int)(i * 2), bytes.Length);
                }
            }
        }
    }

}
