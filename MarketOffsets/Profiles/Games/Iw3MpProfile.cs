namespace MarketOffsets.Profiles.Games;

public sealed class Iw3MpProfile : GameProfileBase
{
    public override string ProcessName => "iw3mp";
    public override string DisplayName => "Call of Duty 4: Modern Warfare - Multiplayer";
    public override int DvarStructOffset => 0xC;

    public override nint? Cg_Fov => 0x8C13D8;
    public override nint? Cg_FovMin => 0x740624;
    public override nint? Cg_FovScale => 0x8BE2E4;
    public override nint? Com_MaxFps => 0x146EEF8;

    public override nint? R_LightMap => 0xD560A7C;
    public override nint? R_SpecularMap => 0xD560A60;
    public override nint? R_FilmUseTweaks => 0xD560984;

    public override nint? Cg_Brass => 0x740644;
    public override nint? R_Fog => 0xD560BF4;
    public override nint? R_Glow => 0xD560A8C;
    public override nint? R_Detail => 0xD560A78;
    public override nint? R_DetailMap => 0xD560A78;

    public override nint? Cbuf_AddText => 0x56C230;
}
