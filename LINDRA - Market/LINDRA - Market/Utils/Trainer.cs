using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace LINDRA___Market.Utils
{
    /// <summary>
    /// Universal trainer compatible with x32 and x64 architectures
    /// Uses IntPtr internally but accepts int for backwards compatibility
    /// </summary>
    internal class Trainer
    {
        private IntPtr aProcess;

        private IntPtr pHandel;

        private long baseAddress;

        private bool isx64 = false;

        private int pointerSize = 4;

        const ushort IMAGE_FILE_MACHINE_UNKNOWN = 0x0000;
        const ushort IMAGE_FILE_MACHINE_I386 = 0x014C;
        const ushort IMAGE_FILE_MACHINE_AMD64 = 0x8664;

        [DllImport("kernel32.dll")]
        private static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint dwFreeType);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process2(IntPtr hProcess, out ushort processMachine, out ushort nativeMachine);

        public bool Process_Handle(string ProcessName)
        {
            try
            {
                Process[] processesByName = Process.GetProcessesByName(ProcessName);
                if (processesByName.Length == 0)
                {
                    return false;
                }
                pHandel = OpenProcess(0x001f0fff, false, processesByName[0].Id);
                if (!IsWow64Process2(pHandel, out ushort processMachine, out ushort nativeMachine))
                {
                    throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
                }
                if (processMachine == IMAGE_FILE_MACHINE_UNKNOWN &&
                    nativeMachine == IMAGE_FILE_MACHINE_AMD64)
                {
                    // Processus x64 natif
                    SetModuleBaseAddress(ProcessName);

                    this.pointerSize = 8;
                    this.isx64 = true;
                }
                else if (processMachine == IMAGE_FILE_MACHINE_I386)
                {
                    // Processus x86 sous WOW64
                    this.pointerSize = 4;
                    this.isx64 = false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Process_Handle - " + ex.Message);
                return false;
            }
        }

        private void SetModuleBaseAddress(string ProcessName)
        {
            Process[] processesByName = Process.GetProcessesByName(ProcessName);
            if (processesByName.Length == 0)
            {
                this.baseAddress = 0L;
            }
            this.baseAddress = processesByName[0].MainModule.BaseAddress.ToInt64();
        }

        public long GetModuleBaseAddress(string ProcessName)
        {
            return this.baseAddress;
        }

        private byte[] Read(long Address, int Length)
        {
            if (isx64 && Length == 8)
            {
                Address = this.baseAddress + Address;
            }
            byte[] array = new byte[Length];
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            ReadProcessMemory(pHandel, (IntPtr)Address, array, (uint)array.Length, out lpNumberOfBytesWritten);
            return array;
        }

        private void Write(long Address, int Value)
        {
            byte[] bytes = BitConverter.GetBytes(Value);
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out lpNumberOfBytesWritten);
        }

        public void WriteInteger(long Address, int Value)
        {
            Write(Address, Value);
        }

        public void WriteFloat(long Address, float Float)
        {
            byte[] bytes = BitConverter.GetBytes(Float);
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, new IntPtr(Address), bytes, 4u, out lpNumberOfBytesWritten);
        }

        public void WriteString(long Address, string Text)
        {
            byte[] bytes = new ASCIIEncoding().GetBytes(Text);
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out lpNumberOfBytesWritten);
        }

        public void WriteBytes(long Address, byte[] Bytes)
        {
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out lpNumberOfBytesWritten);
        }
        public void WriteBytes(IntPtr Address, byte[] Bytes)
        {
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, Address, Bytes, (uint)Bytes.Length, out lpNumberOfBytesWritten);
        }

        public void WriteNOP(long Address, byte[] array)
        {
            IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, array, (uint)array.Length, out lpNumberOfBytesWritten);
        }

        public void rInt(uint Address, int iInt)
        {
            Read(Address, BitConverter.GetBytes(iInt), 4);
        }

        private void write(uint aAddress, byte[] vValue, int sSize)
        {
            WriteProcessMemory(aProcess, (IntPtr)(long)aAddress, vValue, (uint)sSize, out IntPtr _);
        }

        private void Read(uint aAddress, byte[] vValue, int sSize)
        {
            ReadProcessMemory(aProcess, (IntPtr)(long)aAddress, vValue, (uint)sSize, out IntPtr _);
        }

        public int ReadInteger(long Address)
        {
            return BitConverter.ToInt32(Read(Address, this.pointerSize), 0);
        }

        public long ReadLong(long Address)
        {
            return BitConverter.ToInt64(Read(Address, this.pointerSize), 0);
        }

        public T ReadIntOrLong<T>(long Address)
        {
            if (this.pointerSize == 4)
            {
                return (T)(object)BitConverter.ToInt32(Read(Address, this.pointerSize), 0);
            }
            else
            {
                return (T)(object)BitConverter.ToInt64(Read(Address, this.pointerSize), 0);
            }
        }

        public string ReadString(long Address)
        {
            return new ASCIIEncoding().GetString(Read(Address, this.pointerSize));
        }

        public double ReadFloat(long Address)
        {
            return BitConverter.ToSingle(Read(Address, this.pointerSize), 0);
        }

        public byte[] ReadBytes(long Address, int Length)
        {
            return Read(Address, Length);
        }

        public IntPtr MemoryAllocation(byte[] array)
        {
            return VirtualAllocEx(pHandel, IntPtr.Zero, (IntPtr)(array.Length), 0x1000 | 0x2000, 0x40);
        }
        public void FreeMemomryAllocation(IntPtr Address, byte[] array)
        {
            VirtualFreeEx(pHandel, Address, array.Length, 0x8000);

        }
        public void CreateRemoteThread(IntPtr Address)
        {
            IntPtr bytesOut;
            CreateRemoteThread(pHandel, IntPtr.Zero, 0, Address, IntPtr.Zero, 0, out bytesOut);
        }
    }
}