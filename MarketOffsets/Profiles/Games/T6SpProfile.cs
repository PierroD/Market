namespace MarketOffsets.Profiles.Games;

public sealed class T6SpProfile : GameProfileBase
{
    public override string ProcessName => "t6sp";
    public override string DisplayName => "Call of Duty: Black Ops II - Singleplayer";
    public override int DvarStructOffset => 0x18;

    public override nint? Cg_Fov => 0x2C75F3C;
    public override nint? Cg_FovMin => 0x2BE1924;
    public override nint? Cg_FovScale => 0x2C75E2C;
    public override nint? Com_MaxFps => 0x27C5480;

    public override nint? R_SpecularMap => 0x32D00A8;
    public override nint? R_FilmUseTweaks => 0x32CFED0;
    public override nint? R_Fog => 0x32D035C;

    public override nint? Cbuf_AddText => 0x6D0EE0;
    public override nint? NopAddress => 0x564A2C;
}
