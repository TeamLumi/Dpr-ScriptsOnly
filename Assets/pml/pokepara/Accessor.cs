using System;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Pml.PokePara
{
    public class Accessor
    {
        public static byte[] IllegalCoreData;
        public static byte[] DummyWriteCoreData;
        public static byte[] IllegalCalcData;
        public static byte[] DummyWriteCalcData;

        public static void Initialize()
        {
            IllegalCoreData = new byte[0x148];
            DummyWriteCoreData = new byte[0x148];
            IllegalCalcData = new byte[0x10];
            DummyWriteCalcData = new byte[0x10];

            Array.Clear(IllegalCoreData, 0, IllegalCoreData.Length);
            Array.Clear(DummyWriteCoreData, 0, DummyWriteCoreData.Length);
            Array.Clear(IllegalCalcData, 0, IllegalCalcData.Length);
            Array.Clear(DummyWriteCalcData, 0, DummyWriteCalcData.Length);

            // The following lines are pseudocode and need to be replaced with actual logic
            //byte bVar2 = GetCoreDataBlockPos(IllegalCoreData[0], 0);
            //byte bVar3 = GetCoreDataBlockPos(IllegalCoreData[0], 2);

            IllegalCalcData[2] = 1;
            //IllegalCoreData[bVar2 * 0x14 + 2] = 0x1ee;

            // Get the instance of PmlUse and msgLangID from PlayerWork, and convert the msgId
            // The actual logic needs to be implemented
            //var instance = PmlUse.GetInstance();
            //int msgLangID = PlayerWork.GetMsgLangID();
            //int convertedMsgId = MessageHelper.ConvertMsgId(msgLangID);

            //IllegalCoreData[bVar3 * 0x50 + 0x42] = (byte)convertedMsgId;
        }

        public static byte[][] BLOCK_POS_TABLE;

        public static byte GetCoreDataBlockPos(uint key, int blockId)
        {
            uint index = (key >> 0xd) & 0x1f;

            // Assert that blockId is less than 5
            UnityEngine.Debug.Assert(blockId < 5);

            if (index < BLOCK_POS_TABLE.Length && blockId < BLOCK_POS_TABLE[index].Length)
            {
                return BLOCK_POS_TABLE[index][blockId];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public byte[] m_pCoreData;
        public byte[] m_pCalcData;
        public AccessState m_accessState;

        public void AttachDecodedData(byte[] coreData, byte[] calcData)
        {
            m_pCoreData = coreData;
            m_pCalcData = calcData;
            m_accessState = new AccessState(); // Assuming AccessState is a class or struct
            UpdateChecksumAndEncode();
        }

        public void UpdateChecksumAndEncode()
        {
            if (!m_accessState.isEncoded && !m_accessState.isFastMode)
            {
                if (m_pCoreData != null)
                {
                    byte[] data = m_pCoreData.Skip(8).Take(0x140).ToArray();
                    ushort checksum = Pml.PokePara.Encoder.CalcChecksum(data, (uint)data.Length);
                    BitConverter.GetBytes(checksum).CopyTo(m_pCoreData, 6);
                    uint key = BitConverter.ToUInt32(m_pCoreData, 0);
                    Pml.PokePara.Encoder.Encode(data, (uint)data.Length, key);
                }

                if (m_pCoreData != null && m_pCalcData != null)
                {
                    uint key = BitConverter.ToUInt32(m_pCoreData, 0);
                    Pml.PokePara.Encoder.Encode(m_pCalcData, (uint)m_pCalcData.Length, key);
                }

                m_accessState.isEncoded = true;
            }
        }

        public void AttachEncodedData(byte[] coreData, byte[] calcData)
        {
            this.m_pCoreData = coreData;
            this.m_pCalcData = calcData;
            this.m_accessState.isEncoded = true;
        }

        public bool HaveCalcData()
        {
            return this.m_pCalcData != null;
        }

        public void ClearData()
        {
            if (this.m_pCoreData != null)
            {
                Array.Clear(this.m_pCoreData, 0, this.m_pCoreData.Length);
            }

            if (this.m_pCalcData != null)
            {
                Array.Clear(this.m_pCalcData, 0, this.m_pCalcData.Length);
            }

            this.m_accessState.isEncoded = false;
            this.m_accessState.isFastMode = false;
            UpdateChecksumAndEncode();
        }

        public void ClearCalcData()
        {
            if (this.m_pCalcData == null)
            {
                return;
            }

            if (this.m_accessState.isFastMode)
            {
                Array.Clear(this.m_pCalcData, 0, this.m_pCalcData.Length);
                return;
            }

            DecodeAndCheckIllegalWrite();
            this.m_accessState.isFastMode = true;
            Debug.Assert(!this.m_accessState.isEncoded);

            Array.Clear(this.m_pCalcData, 0, this.m_pCalcData.Length);
            this.m_accessState.isFastMode = false;
            UpdateChecksumAndEncode();

            Debug.Assert(!this.m_accessState.isFastMode);
            Debug.Assert(this.m_accessState.isEncoded);
        }

        public bool IsFastMode()
        {
            return this.m_accessState.isFastMode;
        }

        public void StartFastMode()
        {
            DecodeAndCheckIllegalWrite();
            this.m_accessState.isFastMode = true;
            Debug.Assert(!this.m_accessState.isEncoded);
        }

        public void EndFastMode()
        {
            this.m_accessState.isFastMode = false;
            UpdateChecksumAndEncode();

            Debug.Assert(!this.m_accessState.isFastMode);
            Debug.Assert(this.m_accessState.isEncoded);
        }

        public sealed class AccessState : ScriptableObject
        {
            public bool isEncoded;

            public bool isFastMode;
        }

        public void DecodeAndCheckIllegalWrite()
        {
            if (m_accessState.isEncoded)
            {
                if (m_pCoreData != null)
                {
                    Pml.PokePara.Encoder.Decode(m_pCoreData, 0x140, m_pCoreData[0]);
                }

                if (m_pCalcData != null)
                {
                    Pml.PokePara.Encoder.Decode(m_pCalcData, 0x10, m_pCoreData[0]);
                }

                m_accessState.isEncoded = false;

                ushort checksum1 = BitConverter.ToUInt16(m_pCoreData, 6);
                ushort checksum2 = Pml.PokePara.Encoder.CalcChecksum(m_pCoreData, 0x140);

                if (checksum1 != checksum2)
                {
                    coreDataHeader.FuseiTamagoFlag = true;
                }
            }
        }

        public bool IsEncoded()
        {
            return m_accessState.isEncoded;
        }

        public unsafe void Serialize_FullData(byte[] buffer)
        {
            Debug.Assert(buffer.Length > 0x157);
            fixed (byte* pBuffer = buffer)
            {
                IntPtr bufferIntPtr = (IntPtr)pBuffer;
                Serialize(bufferIntPtr, new IntPtr(bufferIntPtr.ToInt64() + 0x148));
            }
        }

        public void Serialize_FullData(IntPtr buffer)
        {
            Serialize(buffer, new IntPtr(buffer.ToInt64() + 0x148));
        }

        public unsafe void Serialize_CoreData(byte[] buffer)
        {
            Debug.Assert(buffer.Length > 0x147);
            fixed (byte* pBuffer = buffer)
            {
                IntPtr bufferIntPtr = (IntPtr)pBuffer;
                Serialize(bufferIntPtr, IntPtr.Zero);
            }
        }

        public void Serialize_CoreData(IntPtr buffer)
        {
            Serialize(buffer, IntPtr.Zero);
        }

        public unsafe void Deserialize_FullData(byte[] serializedData)
        {
            Debug.Assert(serializedData.Length > 0x157);
            fixed (byte* pSerializedData = serializedData)
            {
                IntPtr serializedDataIntPtr = (IntPtr)pSerializedData;
                IntPtr serializedDataIntPtrPlus = new IntPtr(serializedDataIntPtr.ToInt64() + 0x148);
                Deserialize(serializedDataIntPtr, serializedDataIntPtrPlus);
            }
        }


        public void Deserialize_FullData(IntPtr serializedData)
        {
            Deserialize(serializedData, new IntPtr(serializedData.ToInt64() + 0x148));
        }

        public unsafe void Deserialize_CoreData(byte[] serializedData)
        {
            Debug.Assert(serializedData.Length > 0x147);
            fixed (byte* pSerializedData = serializedData)
            {
                IntPtr serializedDataIntPtr = (IntPtr)pSerializedData;
                Deserialize(serializedDataIntPtr, IntPtr.Zero);
            }
        }

        public void Deserialize_CoreData(IntPtr serializedData)
        {
            Deserialize(serializedData, IntPtr.Zero);
        }

        public void Serialize(IntPtr bufferForCore, IntPtr bufferForCalc)
        {
            // Implementation of this method is not provided in the code snippet.
            // You need to implement it according to your requirements.
        }

        public void Deserialize(IntPtr serializedCoreData, IntPtr serializedCalcData)
        {
            // Implementation of this method is not provided in the code snippet.
            // You need to implement it according to your requirements.
        }

        private CoreDataHeader coreDataHeader;

        public Accessor()
        {
            // Initialize CoreDataHeader
            coreDataHeader = new CoreDataHeader();
            // Assuming m_pCoreData is initialized somewhere
        }
    }

    public class PmlUse
    {
        //public static PmlUse GetInstance() { /*...*/ }
    }

    public class PlayerWork
    {
        //public static int GetMsgLangID() { /*...*/ }
    }

    public class MessageHelper
    {
        //public static int ConvertMsgId(int msgLangID) { /*...*/ }
    }
}
