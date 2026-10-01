namespace MarketOffsets.Profiles.Games;

public sealed class Iw4MpProfile : GameProfileBase
{
    public override string ProcessName => "iw4mp";
    public override string DisplayName => "Call of Duty: Modern Warfare 2 - Multiplayer";
    public override bool Is64Bit => true;
    public override int DvarStructOffset => 0x10;

    public override nint? Cg_Fov => 0x809C78;
    public override nint? Cg_FovMin => 0x809C80;
    public override nint? Cg_FovScale => 0x809C88;
    public override nint? Com_MaxFps => 0x1D260A8;

    public override nint? R_LightMap => 0x8CF7A70;
    public override nint? R_SpecularMap => 0x8CF7880;
    public override nint? R_FilmUseTweaks => 0x8CF7950;

    public override nint? Cg_Brass => 0x809BB8;
    public override nint? R_Fog => 0x8CF7C08;
    public override nint? R_Glow => 0x8CF7D78;
    public override nint? R_Detail => 0x8CF7DB0;
    public override nint? R_DetailMap => 0x8CF78A8;

    //public override nint? SafeAreaHorz => 0x81A840;
    //public override nint? SafeAreaVert => 0x81A848;

    public override nint? Cbuf_AddText => 0x1E6500;
}
