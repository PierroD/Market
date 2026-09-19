namespace MarketOffsets.Profiles.Games;

public sealed class Iw4MpProfile : GameProfileBase
{
    public override string ProcessName => "iw4mp";
    public override string DisplayName => "Call of Duty: Modern Warfare 2 - Multiplayer";
    public override bool Is64Bit => true;
    public override int DvarStructOffset => 0x10;

    public override nint? Cg_Fov => 0x6BD178;
    public override nint? Cg_FovMin => 0x6BD180;
    public override nint? Cg_FovScale => 0x6BD188;
    public override nint? Com_MaxFps => 0x1BD95A8;

    public override nint? R_LightMap => 0x8CC6870;
    public override nint? R_SpecularMap => 0x8CC6680;
    public override nint? R_FilmUseTweaks => 0x8CC6750;

    public override nint? Cg_Brass => 0x06BD0B8;
    public override nint? R_Fog => 0x8CC6A08;
    public override nint? R_Glow => 0x8CC6B78;
    public override nint? R_Detail => 0x8CC6BB0;
    public override nint? R_DetailMap => 0x8CC66A8;

    public override nint? SafeAreaHorz => 0x6CCCA0;
    public override nint? SafeAreaVert => 0x6CCCA8;

    public override nint? Cbuf_AddText => 0x1E6DC0;
}
