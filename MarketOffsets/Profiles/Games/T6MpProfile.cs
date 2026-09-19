namespace MarketOffsets.Profiles.Games;

public sealed class T6MpProfile : GameProfileBase
{
    public override string ProcessName => "t6mp";
    public override string DisplayName => "Call of Duty: Black Ops II - Multiplayer";
    public override int DvarStructOffset => 0x18;

    public override nint? Cg_Fov => 0x10647BC;
    public override nint? Cg_FovMin => 0xFCC73C;
    public override nint? Cg_FovScale => 0x1062DC0;
    public override nint? Com_MaxFps => 0x250642C;

    public override nint? R_SpecularMap => 0x34C7238;
    public override nint? R_FilmUseTweaks => 0x34C7060;
    public override nint? R_Fog => 0x34C74EC;

    public override nint? Cbuf_AddText => 0x6BAD90;
    public override nint? NopAddress => 0x54EC1C;
}
