namespace MarketOffsets.Profiles.Games;

public sealed class T6ZmProfile : GameProfileBase
{
    public override string ProcessName => "t6zm";
    public override string DisplayName => "Call of Duty: Black Ops II - Zombies";
    public override int DvarStructOffset => 0x18;

    public override nint? Cg_Fov => 0x106284C;
    public override nint? Cg_FovMin => 0xFCA7CC;
    public override nint? Cg_FovScale => 0x1060E50;
    public override nint? Com_MaxFps => 0x25044AC;

    public override nint? R_SpecularMap => 0x34C52B8;
    public override nint? R_FilmUseTweaks => 0x34C50E0;
    public override nint? R_Fog => 0x34C556C;

    public override nint? Cbuf_AddText => 0x6BBE40;
    public override nint? NopAddress => 0x550BCC;
}
