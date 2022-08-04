using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace MarketOffsets.Utils
{
	internal class Trainer
	{
		private IntPtr aProcess;

		private IntPtr pHandel;

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
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Process_Handle - " + ex.Message);
				return false;
			}
		}

		private byte[] Read(int Address, int Length)
		{
			byte[] array = new byte[Length];
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			ReadProcessMemory(pHandel, (IntPtr)Address, array, (uint)array.Length, out lpNumberOfBytesWritten);
			return array;
		}

		private void Write(int Address, int Value)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			WriteProcessMemory(pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out lpNumberOfBytesWritten);
		}

		public void WriteInteger(int Address, int Value)
		{
			Write(Address, Value);
		}

		public void WriteFloat(int Address, float Float)
		{
			byte[] bytes = BitConverter.GetBytes(Float);
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			WriteProcessMemory(pHandel, new IntPtr(Address), bytes, 4u, out lpNumberOfBytesWritten);
		}

		public void WriteString(int Address, string Text)
		{
			byte[] bytes = new ASCIIEncoding().GetBytes(Text);
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			WriteProcessMemory(pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out lpNumberOfBytesWritten);
		}

		public void WriteBytes(int Address, byte[] Bytes)
		{
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			WriteProcessMemory(pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out lpNumberOfBytesWritten);
		}
		public void WriteBytes(IntPtr Address, byte[] Bytes)
		{
			IntPtr lpNumberOfBytesWritten = IntPtr.Zero;
			WriteProcessMemory(pHandel, Address, Bytes, (uint)Bytes.Length, out lpNumberOfBytesWritten);
		}

		public void WriteNOP(int Address, byte[] array)
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

		public int ReadInteger(int Address, int Length = 4)
		{
			return BitConverter.ToInt32(Read(Address, Length), 0);
		}

		public string ReadString(int Address, int Length = 4)
		{
			return new ASCIIEncoding().GetString(Read(Address, Length));
		}

		public double ReadFloat(int Address, int Length = 4)
		{
			return BitConverter.ToSingle(Read(Address, Length), 0);
		}

		public byte[] ReadBytes(int Address, int Length)
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

