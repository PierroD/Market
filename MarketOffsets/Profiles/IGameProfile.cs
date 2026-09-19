using MarketOffsets.Engine;
using MarketOffsets.Models;

namespace MarketOffsets.Profiles;

public interface IGameProfile
{
    string ProcessName { get; }
    string DisplayName { get; }
    bool Is64Bit { get; }
    int DvarStructOffset { get; }

    // Dvar Offsets (null if unsupported)
    nint? Cg_Fov { get; }
    nint? Cg_FovMin { get; }
    nint? Cg_FovScale { get; }
    nint? Com_MaxFps { get; }

    nint? R_LightMap { get; }
    nint? R_SpecularMap { get; }
    nint? R_FilmUseTweaks { get; }

    nint? Cg_Brass { get; }
    nint? R_Fog { get; }
    nint? R_Glow { get; }
    nint? R_Detail { get; }
    nint? R_DetailMap { get; }

    nint? SafeAreaHorz { get; }
    nint? SafeAreaVert { get; }

    nint? Cbuf_AddText { get; }
    nint? NopAddress { get; }

    // Feature capability flags
    bool SupportsLightMap => R_LightMap.HasValue;
    bool SupportsSpecularMap => R_SpecularMap.HasValue;
    bool SupportsFilmUseTweaks => R_FilmUseTweaks.HasValue;
    bool SupportsSafeArea => SafeAreaHorz.HasValue && SafeAreaVert.HasValue;
    bool SupportsConsole => Cbuf_AddText.HasValue;

    void ApplyVisualsConfig(IMemoryEngine memory, IVisualsSettings config);
}
