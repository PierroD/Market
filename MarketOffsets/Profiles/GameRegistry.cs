using System;
using System.Collections.Generic;
using System.Diagnostics;
using MarketOffsets.Profiles.Games;

namespace MarketOffsets.Profiles;

public static class GameRegistry
{
    private static readonly Dictionary<string, IGameProfile> ProfilesByProcessName = new(StringComparer.OrdinalIgnoreCase);

    public static IReadOnlyCollection<IGameProfile> AllProfiles => ProfilesByProcessName.Values;

    static GameRegistry()
    {
        Register(new Iw3MpProfile());
        Register(new Iw4MpProfile());
        Register(new Iw4SpProfile());
        Register(new Iw5MpProfile());
        Register(new BlackOpsMpProfile());
        Register(new T6MpProfile());
        Register(new T6SpProfile());
        Register(new T6ZmProfile());
    }

    public static void Register(IGameProfile profile)
    {
        ProfilesByProcessName[profile.ProcessName] = profile;
    }

    public static bool TryGetProfile(string processName, out IGameProfile? profile)
    {
        return ProfilesByProcessName.TryGetValue(processName, out profile);
    }

    public static (IGameProfile? Profile, Process? Process) FindRunningGame()
    {
        foreach (var kvp in ProfilesByProcessName)
        {
            var processes = Process.GetProcessesByName(kvp.Key);
            if (processes.Length > 0)
            {
                var process = processes[0];
                if (!process.HasExited)
                {
                    return (kvp.Value, process);
                }
            }
        }

        return (null, null);
    }
}
