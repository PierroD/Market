namespace MarketOffsets.Profiles.Games;

public sealed class BlackOpsMpProfile : GameProfileBase
{
    public override string ProcessName => "BlackOpsMP";
    public override string DisplayName => "Call of Duty: Black Ops - Multiplayer";
    public override int DvarStructOffset => 0x18;

    public override nint? Cg_Fov => 0xD52624;
    public override nint? Cg_FovMin => 0xCC19CC;
    public override nint? Cg_FovScale => 0xD52388;
    public override nint? Com_MaxFps => 0x35A039C;

    public override nint? R_LightMap => 0x48A4CAC;
    public override nint? R_SpecularMap => 0x48A4C14;
    public override nint? R_FilmUseTweaks => 0x48A4A3C;

    public override nint? Cg_Brass => 0xCC1A14;
    public override nint? R_Fog => 0x48A4F6C;

    public override nint? Cbuf_AddText => 0x56EF70;
    public override nint? NopAddress => 0x8B5A37;
}
