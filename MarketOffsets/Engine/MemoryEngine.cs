using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using MarketOffsets.Native;
using Microsoft.Win32.SafeHandles;

namespace MarketOffsets.Engine;

public sealed class MemoryEngine : IMemoryEngine
{
    private SafeProcessHandle? _processHandle;
    private Process? _attachedProcess;
    private const nint DefaultPeBase = 0x400000;
    private readonly object _commandLock = new();

    public bool IsAttached => _processHandle != null && !_processHandle.IsInvalid && !_processHandle.IsClosed;
    public int ProcessId => _attachedProcess?.Id ?? 0;
    public nint BaseAddress { get; private set; } = 0;
    public bool Is64Bit { get; private set; } = false;

    public bool Attach(Process process, bool? is64Bit = null)
    {
        ArgumentNullException.ThrowIfNull(process);

        Detach();

        try
        {
            if (process.HasExited)
                return false;

            var handle = NativeMethods.OpenProcess(
                NativeMethods.DEFAULT_PROCESS_ACCESS,
                false,
                process.Id);

            if (handle.IsInvalid)
                return false;

            _processHandle = handle;
            _attachedProcess = process;

            // Architecture detection (override from profile or auto-detect WoW64)
            if (is64Bit.HasValue)
            {
                Is64Bit = is64Bit.Value;
            }
            else if (Environment.Is64BitOperatingSystem)
            {
                if (NativeMethods.IsWow64Process(_processHandle, out bool isWow64))
                {
                    // If isWow64 is true, the process is a 32-bit process running under 64-bit Windows.
                    Is64Bit = !isWow64;
                }
                else
                {
                    Is64Bit = false;
                }
            }
            else
            {
                Is64Bit = false;
            }

            // Resolve module base address
            try
            {
                BaseAddress = process.MainModule?.BaseAddress ?? 0;
            }
            catch
            {
                BaseAddress = 0;
            }

            return true;
        }
        catch
        {
            Detach();
            return false;
        }
    }

    public void Detach()
    {
        if (_processHandle != null && !_processHandle.IsClosed)
        {
            _processHandle.Dispose();
            _processHandle = null;
        }

        _attachedProcess = null;
        BaseAddress = 0;
        Is64Bit = false;
    }

    public nint ResolveAddress(nint rawAddress)
    {
        if (rawAddress == 0) return 0;

        // In 64-bit games, offsets (e.g., 0x51E1A8 for iw4sp) are Relative to BaseAddress
        if (Is64Bit)
        {
            return BaseAddress != 0 ? BaseAddress + rawAddress : rawAddress;
        }

        // In 32-bit games:
        // If ASLR relocated the binary away from standard 0x400000 base
        if (BaseAddress != 0 && BaseAddress != DefaultPeBase)
        {
            return rawAddress + (BaseAddress - DefaultPeBase);
        }

        return rawAddress;
    }

    public bool ReadBytes(nint address, byte[] buffer)
    {
        if (!IsAttached || _processHandle == null || address == 0 || buffer.Length == 0)
            return false;

        return NativeMethods.ReadProcessMemory(
            _processHandle,
            address,
            buffer,
            (nuint)buffer.Length,
            out _);
    }

    public bool ReadInt32(nint address, out int value)
    {
        value = 0;
        byte[] buffer = new byte[4];
        if (!ReadBytes(address, buffer))
            return false;

        value = BitConverter.ToInt32(buffer, 0);
        return true;
    }

    public bool ReadInt64(nint address, out long value)
    {
        value = 0;
        byte[] buffer = new byte[8];
        if (!ReadBytes(address, buffer))
            return false;

        value = BitConverter.ToInt64(buffer, 0);
        return true;
    }

    public bool ReadPointer(nint address, out nint value)
    {
        value = 0;
        if (Is64Bit)
        {
            if (ReadInt64(address, out long val64))
            {
                value = (nint)val64;
                return true;
            }
            return false;
        }

        if (ReadInt32(address, out int val32))
        {
            value = (nint)val32;
            return true;
        }
        return false;
    }

    public bool ReadFloat(nint address, out float value)
    {
        value = 0f;
        byte[] buffer = new byte[4];
        if (!ReadBytes(address, buffer))
            return false;

        value = BitConverter.ToSingle(buffer, 0);
        return true;
    }

    public bool WriteBytes(nint address, byte[] data)
    {
        if (!IsAttached || _processHandle == null || address == 0 || data.Length == 0)
            return false;

        return NativeMethods.WriteProcessMemory(
            _processHandle,
            address,
            data,
            (nuint)data.Length,
            out _);
    }

    public bool WriteInt32(nint address, int value)
    {
        return WriteBytes(address, BitConverter.GetBytes(value));
    }

    public bool WriteInt64(nint address, long value)
    {
        return WriteBytes(address, BitConverter.GetBytes(value));
    }

    public bool WriteFloat(nint address, float value)
    {
        return WriteBytes(address, BitConverter.GetBytes(value));
    }

    public bool WriteDvarInt(nint? dvarOffset, int dvarStructOffset, int value)
    {
        if (dvarOffset == null || dvarOffset.Value == 0)
            return false;

        nint resolvedDvarAddress = ResolveAddress(dvarOffset.Value);

        // Read the pointer to the dvar_t structure (automatically reads 8 bytes on x64, 4 bytes on x86)
        if (!ReadPointer(resolvedDvarAddress, out nint dvarStructPtr) || dvarStructPtr == 0)
            return false;

        // Target address inside the struct
        nint targetAddress = dvarStructPtr + dvarStructOffset;
        return WriteInt32(targetAddress, value);
    }

    public bool WriteDvarInt64(nint? dvarOffset, int dvarStructOffset, long value)
    {
        if (dvarOffset == null || dvarOffset.Value == 0)
            return false;

        nint resolvedDvarAddress = ResolveAddress(dvarOffset.Value);

        // Read the pointer to the dvar_t structure (automatically reads 8 bytes on x64, 4 bytes on x86)
        if (!ReadPointer(resolvedDvarAddress, out nint dvarStructPtr) || dvarStructPtr == 0)
            return false;

        // Target address inside the struct
        nint targetAddress = dvarStructPtr + dvarStructOffset;
        return WriteInt64(targetAddress, value);
    }

    public bool WriteDvarFloat(nint? dvarOffset, int dvarStructOffset, float value)
    {
        if (dvarOffset == null || dvarOffset.Value == 0)
            return false;

        nint resolvedDvarAddress = ResolveAddress(dvarOffset.Value);

        // Read the pointer to the dvar_t structure
        if (!ReadPointer(resolvedDvarAddress, out nint dvarStructPtr) || dvarStructPtr == 0)
            return false;

        // Target address inside the struct
        nint targetAddress = dvarStructPtr + dvarStructOffset;
        return WriteFloat(targetAddress, value);
    }

    public bool ExecuteCommand(nint cbufAddTextAddress, string command, nint nopAddress = 0)
    {
        if (!IsAttached || _processHandle == null || cbufAddTextAddress == 0 || string.IsNullOrWhiteSpace(command))
            return false;

        lock (_commandLock)
        {
            nint resolvedCbuf = ResolveAddress(cbufAddTextAddress);
            nint resolvedNop = nopAddress != 0 ? ResolveAddress(nopAddress) : 0;

            try
            {
                // If game requires NOP patch (e.g., BO1 command check bypass)
                if (resolvedNop != 0)
                {
                    byte[] nopBytes = [0x90, 0x90];
                    WriteBytes(resolvedNop, nopBytes);
                }

                // In Quake/IW engine, commands MUST end with a newline '\n' (or ';')
                // Otherwise the engine command parser concatenates subsequent commands without executing them.
                string formattedCommand = command.Trim();
                if (!formattedCommand.EndsWith('\n'))
                {
                    formattedCommand += "\n";
                }

                byte[] commandBytes = Encoding.ASCII.GetBytes(formattedCommand + "\0");

                // Allocate memory for the command string
                nint cmdAlloc = NativeMethods.VirtualAllocEx(
                    _processHandle,
                    0,
                    (nuint)commandBytes.Length,
                    NativeMethods.MEM_COMMIT | NativeMethods.MEM_RESERVE,
                    NativeMethods.PAGE_EXECUTE_READWRITE);

                if (cmdAlloc == 0)
                    return false;

                WriteBytes(cmdAlloc, commandBytes);

                byte[] wrapper;

                if (Is64Bit)
                {
                    // Assembly wrapper for x64: Fastcall (RCX = 0, RDX = cmdAlloc), shadow space 32 bytes
                    wrapper =
                    [
                        0x48, 0x83, 0xEC, 0x28,                     // sub rsp, 0x28
                        0x33, 0xC9,                                 // xor ecx, ecx (clientNum = 0)
                        0x48, 0xBA, 0, 0, 0, 0, 0, 0, 0, 0,         // mov rdx, cmdAlloc (offset 8)
                        0x48, 0xB8, 0, 0, 0, 0, 0, 0, 0, 0,         // mov rax, resolvedCbuf (offset 18)
                        0xFF, 0xD0,                                 // call rax
                        0x48, 0x83, 0xC4, 0x28,                     // add rsp, 0x28
                        0xC3                                        // ret
                    ];

                    byte[] cmdAllocBytes = BitConverter.GetBytes((long)cmdAlloc);
                    byte[] cbufBytes = BitConverter.GetBytes((long)resolvedCbuf);
                    Array.Copy(cmdAllocBytes, 0, wrapper, 8, 8);
                    Array.Copy(cbufBytes, 0, wrapper, 18, 8);
                }
                else
                {
                    // Assembly wrapper for x86: __cdecl (push cmd, push clientNum)
                    wrapper =
                    [
                        0x55,                               // push ebp
                        0x8B, 0xEC,                         // mov ebp, esp
                        0x83, 0xEC, 0x08,                   // sub esp, 8
                        0xC7, 0x45, 0xF8, 0, 0, 0, 0,       // mov [ebp-8], cmdAlloc
                        0xC7, 0x45, 0xFC, 0, 0, 0, 0,       // mov [ebp-4], resolvedCbuf
                        0xFF, 0x75, 0xF8,                   // push [ebp-8]
                        0x6A, 0x00,                         // push 0 (clientNum)
                        0xFF, 0x55, 0xFC,                   // call [ebp-4]
                        0x83, 0xC4, 0x08,                   // add esp, 8
                        0x8B, 0xE5,                         // mov esp, ebp
                        0x5D,                               // pop ebp
                        0xC3                                // ret
                    ];

                    byte[] cmdAllocBytes = BitConverter.GetBytes((int)cmdAlloc);
                    byte[] cbufBytes = BitConverter.GetBytes((int)resolvedCbuf);
                    Array.Copy(cmdAllocBytes, 0, wrapper, 9, 4);
                    Array.Copy(cbufBytes, 0, wrapper, 16, 4);
                }

                // Allocate memory for wrapper shellcode
                nint wrapperAlloc = NativeMethods.VirtualAllocEx(
                    _processHandle,
                    0,
                    (nuint)wrapper.Length,
                    NativeMethods.MEM_COMMIT | NativeMethods.MEM_RESERVE,
                    NativeMethods.PAGE_EXECUTE_READWRITE);

                if (wrapperAlloc == 0)
                {
                    NativeMethods.VirtualFreeEx(_processHandle, cmdAlloc, 0, NativeMethods.MEM_RELEASE);
                    return false;
                }

                WriteBytes(wrapperAlloc, wrapper);

                // Execute shellcode remotely
                nint hThread = NativeMethods.CreateRemoteThread(
                    _processHandle,
                    0,
                    0,
                    wrapperAlloc,
                    0,
                    0,
                    out _);

                if (hThread != 0)
                {
                    NativeMethods.WaitForSingleObject(hThread, 1000);
                    NativeMethods.CloseHandle(hThread);
                }
                else
                {
                    // Fallback wait if CreateRemoteThread handle was not returned
                    System.Threading.Thread.Sleep(50);
                }

                NativeMethods.VirtualFreeEx(_processHandle, wrapperAlloc, 0, NativeMethods.MEM_RELEASE);
                NativeMethods.VirtualFreeEx(_processHandle, cmdAlloc, 0, NativeMethods.MEM_RELEASE);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public void Dispose()
    {
        Detach();
    }
}
