using MarketOffsets.Models;

namespace Lindra_Market_v3.Tools.FpsUnlocker.Models;

public class VisualsConfig : IVisualsSettings
{
    public double FieldOfView { get; set; } = 65;
    public double MaxFps { get; set; } = 90;
    public double FovScale { get; set; } = 1000;
    public double FovMinimum { get; set; } = 1;

    public int LightMapIndex { get; set; } = 0;
    public int SpecularMapIndex { get; set; } = 0;

    public bool IsMovieEnabled { get; set; } = false;
    public bool IsNoFogEnabled { get; set; } = false;
    public bool IsNoGlowEnabled { get; set; } = false;
    public bool IsNoBulletEnabled { get; set; } = false;
    public bool IsNoCamosEnabled { get; set; } = false;
}
