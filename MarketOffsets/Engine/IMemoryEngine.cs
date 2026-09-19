using System;
using System.Diagnostics;

namespace MarketOffsets.Engine;

public interface IMemoryEngine : IDisposable
{
    bool IsAttached { get; }
    int ProcessId { get; }
    nint BaseAddress { get; }
    bool Is64Bit { get; }

    bool Attach(Process process, bool? is64Bit = null);
    void Detach();

    bool ReadBytes(nint address, byte[] buffer);
    bool ReadInt32(nint address, out int value);
    bool ReadInt64(nint address, out long value);
    bool ReadPointer(nint address, out nint value);
    bool ReadFloat(nint address, out float value);

    bool WriteBytes(nint address, byte[] data);
    bool WriteInt32(nint address, int value);
    bool WriteInt64(nint address, long value);
    bool WriteFloat(nint address, float value);

    // Dvar specific helpers
    bool WriteDvarInt(nint? dvarOffset, int dvarStructOffset, int value);
    bool WriteDvarInt64(nint? dvarOffset, int dvarStructOffset, long value);
    bool WriteDvarFloat(nint? dvarOffset, int dvarStructOffset, float value);

    // Console execution
    bool ExecuteCommand(nint cbufAddTextAddress, string command, nint nopAddress = 0);
}
