namespace MarketOffsets.Profiles.Games;

public sealed class Iw4SpProfile : GameProfileBase
{
    public override string ProcessName => "iw4sp";
    public override string DisplayName => "Call of Duty: Modern Warfare 2 - Singleplayer";
    public override bool Is64Bit => true;
    public override int DvarStructOffset => 0x10;

    public override nint? Cg_Fov => 0x51E1A8;
    public override nint? Cg_FovMin => 0x51E1B0;
    public override nint? Cg_FovScale => 0x51E1B8;
    public override nint? Com_MaxFps => 0x1325C28;

    public override nint? R_LightMap => 0x4116148;
    public override nint? R_SpecularMap => 0x4116428;
    public override nint? R_FilmUseTweaks => 0x4116028;

    public override nint? Cg_Brass => 0x51E118;
    public override nint? R_Fog => 0x4116300;
    public override nint? R_Glow => 0x41163E0;
    public override nint? R_Detail => 0x4116400;
    public override nint? R_DetailMap => 0x4116450;

    public override nint? SafeAreaHorz => 0x5DF530;
    public override nint? SafeAreaVert => 0x5DF538;

    public override nint? Cbuf_AddText => 0x1EE890;
}
