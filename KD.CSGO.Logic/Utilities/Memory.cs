using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace KD.CSGO.Logic.Utilities
{
    /// <summary>
    /// Used for memory management.
    /// </summary>
    public static class Memory
    {
        public const uint DELETE = 0x00010000;
        public const uint READ_CONTROL = 0x00020000;
        public const uint WRITE_DAC = 0x00040000;
        public const uint WRITE_OWNER = 0x00080000;
        public const uint SYNCHRONIZE = 0x00100000;
        public const uint END = 0xFFF; //if you have WinXP or Windows Server 2003 you must change this to 0xFFFF
        public const uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesRead);
        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);

        public static byte[] ReadMemory(int address, int processSize, int processHandle)
        {
            byte[] buffer = new byte[processSize];
            ReadProcessMemory(processHandle, address, buffer, processSize, 0);
            return buffer;
        }

        public static int ReadMemory(int processHandle, int address)
        {
            byte[] value = ReadMemory(address, 32, processHandle);
            int parsed = BitConverter.ToInt32(value, 0);
            return parsed;
        }

        public static void WriteMemory(int address, byte[] processBytes, int processHandle)
        {
            WriteProcessMemory(processHandle, address, processBytes, processBytes.Length, 0);
        }

        public static void WriteMemory(int processHandle, int address, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteMemory(address, bytes, processHandle);
        }

        public static int GetObjectSize(object obj)
        {
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, obj);
            byte[] bytes = ms.ToArray();
            return bytes.Length;
        }

        public static unsafe TDataType Read<TDataType>(int address)
            where TDataType : struct
        {
            IntPtr addressPtr = new IntPtr(address);
            var ptrAddress = addressPtr.ToPointer();

            object value;

            if (typeof(TDataType) == typeof(IntPtr))
            {
                value = new IntPtr(*(void**)addressPtr);
                return (TDataType)value;
            }

            switch (Type.GetTypeCode(typeof(TDataType)))
            {
                case TypeCode.Boolean:
                    value = *(bool*)ptrAddress;
                    break;
                case TypeCode.Byte:
                    value = *(byte*)ptrAddress;
                    break;
                case TypeCode.SByte:
                    value = *(sbyte*)ptrAddress;
                    break;
                case TypeCode.Char:
                    value = *(char*)ptrAddress;
                    break;
                case TypeCode.Int16:
                    value = *(short*)ptrAddress;
                    break;
                case TypeCode.UInt16:
                    value = *(ushort*)ptrAddress;
                    break;
                case TypeCode.Int32:
                    value = *(int*)ptrAddress;
                    break;
                case TypeCode.UInt32:
                    value = *(uint*)ptrAddress;
                    break;
                case TypeCode.Int64:
                    value = *(long*)ptrAddress;
                    break;
                case TypeCode.UInt64:
                    value = *(ulong*)ptrAddress;
                    break;
                case TypeCode.Single:
                    value = *(float*)ptrAddress;
                    break;
                case TypeCode.Double:
                    value = *(double*)ptrAddress;
                    break;
                default:
                    // For custome structure:
                    value = Marshal.PtrToStructure(addressPtr, typeof(TDataType));
                    break;
            }

            return (TDataType)value;
        }

        public static unsafe void Write<TDataType>(int address, TDataType value)
        {
            IntPtr addressPtr = new IntPtr(address);
            var ptrAddress = addressPtr.ToPointer();

            object objectValue = value;

            if (typeof(TDataType) == typeof(IntPtr))
            {
                *((void**)ptrAddress) = ((IntPtr)objectValue).ToPointer();
            }

            switch (Type.GetTypeCode(typeof(TDataType)))
            {
                case TypeCode.Boolean:
                    *(bool*)ptrAddress = (bool)objectValue;
                    break;
                case TypeCode.Byte:
                    *(byte*)ptrAddress = (byte)objectValue;
                    break;
                case TypeCode.SByte:
                    *(sbyte*)ptrAddress = (sbyte)objectValue;
                    break;
                case TypeCode.Char:
                    *(char*)ptrAddress = (char)objectValue;
                    break;
                case TypeCode.Int16:
                    *(short*)ptrAddress = (short)objectValue;
                    break;
                case TypeCode.UInt16:
                    *(ushort*)ptrAddress = (ushort)objectValue;
                    break;
                case TypeCode.Int32:
                    *(int*)ptrAddress = (int)objectValue;
                    break;
                case TypeCode.UInt32:
                    *(uint*)ptrAddress = (uint)objectValue;
                    break;
                case TypeCode.Int64:
                    *(long*)ptrAddress = (long)objectValue;
                    break;
                case TypeCode.UInt64:
                    *(ulong*)ptrAddress = (ulong)objectValue;
                    break;
                case TypeCode.Single:
                    *(float*)ptrAddress = (float)objectValue;
                    break;
                case TypeCode.Double:
                    *(double*)ptrAddress = (double)objectValue;
                    break;
                default:
                    // assume a custom struct, lets try
                    Marshal.StructureToPtr(objectValue, addressPtr, true);
                    break;
            }
        }
    }
}