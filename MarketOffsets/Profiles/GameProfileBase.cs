using MarketOffsets.Engine;
using MarketOffsets.Models;

namespace MarketOffsets.Profiles;

public abstract class GameProfileBase : IGameProfile
{
    public abstract string ProcessName { get; }
    public abstract string DisplayName { get; }
    public virtual bool Is64Bit => false;
    public virtual bool Use64BitDvarValues => false;
    public abstract int DvarStructOffset { get; }

    public virtual nint? Cg_Fov => null;
    public virtual nint? Cg_FovMin => null;
    public virtual nint? Cg_FovScale => null;
    public virtual nint? Com_MaxFps => null;

    public virtual nint? R_LightMap => null;
    public virtual nint? R_SpecularMap => null;
    public virtual nint? R_FilmUseTweaks => null;

    public virtual nint? Cg_Brass => null;
    public virtual nint? R_Fog => null;
    public virtual nint? R_Glow => null;
    public virtual nint? R_Detail => null;
    public virtual nint? R_DetailMap => null;

    public virtual nint? SafeAreaHorz => null;
    public virtual nint? SafeAreaVert => null;

    public virtual nint? Cbuf_AddText => null;
    public virtual nint? NopAddress => null;

    protected virtual bool WriteDvarInteger(IMemoryEngine memory, nint? dvarOffset, int value)
    {
        if (Use64BitDvarValues)
            return memory.WriteDvarInt64(dvarOffset, DvarStructOffset, value);

        return memory.WriteDvarInt(dvarOffset, DvarStructOffset, value);
    }

    public virtual void ApplyVisualsConfig(IMemoryEngine memory, IVisualsSettings config)
    {
        if (!memory.IsAttached) return;

        // Camera & Performance
        if (Cg_Fov.HasValue)
            memory.WriteDvarFloat(Cg_Fov, DvarStructOffset, (float)config.FieldOfView);

        if (Cg_FovScale.HasValue)
        {
            float scale = (float)config.FovScale / 1000f;
            // Guard against 0 or uninitialized scale which zeroes out the FOV in the game engine
            if (scale <= 0.05f)
                scale = 1.0f;

            memory.WriteDvarFloat(Cg_FovScale, DvarStructOffset, scale);
        }

        if (Cg_FovMin.HasValue)
        {
            float minFov = (float)config.FovMinimum;
            if (minFov <= 0f)
                minFov = 1.0f;

            memory.WriteDvarFloat(Cg_FovMin, DvarStructOffset, minFov);
        }

        if (Com_MaxFps.HasValue)
            WriteDvarInteger(memory, Com_MaxFps, (int)config.MaxFps);

        // Textures & Lighting
        if (R_LightMap.HasValue)
            WriteDvarInteger(memory, R_LightMap, config.LightMapIndex);

        if (R_SpecularMap.HasValue)
            WriteDvarInteger(memory, R_SpecularMap, config.SpecularMapIndex);

        // Visual Tweaks
        if (R_FilmUseTweaks.HasValue)
            WriteDvarInteger(memory, R_FilmUseTweaks, config.IsMovieEnabled ? 1 : 0);

        if (R_Fog.HasValue)
            WriteDvarInteger(memory, R_Fog, config.IsNoFogEnabled ? 0 : 1);

        if (R_Glow.HasValue)
            WriteDvarInteger(memory, R_Glow, config.IsNoGlowEnabled ? 0 : 1);

        if (R_Detail.HasValue)
            WriteDvarInteger(memory, R_Detail, config.IsNoCamosEnabled ? 0 : 1);

        if (R_DetailMap.HasValue)
            WriteDvarInteger(memory, R_DetailMap, config.IsNoCamosEnabled ? 0 : 1);

        if (Cg_Brass.HasValue)
            WriteDvarInteger(memory, Cg_Brass, config.IsNoBulletEnabled ? 0 : 1);
    }
}
