namespace MarketOffsets.Models;

public interface IVisualsSettings
{
    double FieldOfView { get; set; }
    double MaxFps { get; set; }
    double FovScale { get; set; }
    double FovMinimum { get; set; }

    int LightMapIndex { get; set; }
    int SpecularMapIndex { get; set; }

    bool IsMovieEnabled { get; set; }
    bool IsNoFogEnabled { get; set; }
    bool IsNoGlowEnabled { get; set; }
    bool IsNoBulletEnabled { get; set; }
    bool IsNoCamosEnabled { get; set; }
}
