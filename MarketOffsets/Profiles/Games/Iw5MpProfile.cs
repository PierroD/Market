namespace MarketOffsets.Profiles.Games;

public sealed class Iw5MpProfile : GameProfileBase
{
    public override string ProcessName => "iw5mp";
    public override string DisplayName => "Call of Duty: Modern Warfare 3 - Multiplayer";
    public override bool Is64Bit => true;
    public override int DvarStructOffset => 0x10;

    public override nint? Cg_Fov => 0x7D2688;
    public override nint? Cg_FovMin => 0x7D2690;
    public override nint? Cg_FovScale => 0x7D2698;
    public override nint? Com_MaxFps => 0x2CDD820;

    public override nint? R_LightMap => 0x264A1A8;
    public override nint? R_SpecularMap => 0x264A1C8;
    public override nint? R_FilmUseTweaks => 0x264A538;

    public override nint? Cg_Brass => 0x7D25D8;
    public override nint? R_Fog => 0x264A138;
    public override nint? R_Glow => 0x264A500;
    public override nint? R_Detail => 0x264A190;
    public override nint? R_DetailMap => 0x264A1B8;

    public override nint? SafeAreaHorz => 0x7FE840;
    public override nint? SafeAreaVert => 0x7FE848;
}
