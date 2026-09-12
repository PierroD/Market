using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw5mp : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {
        public long dvar => 0x10;
        public long cg_fov => 0x7D2688;

        public long cg_fovMin => 0x7D2690;

        public long cg_fovScale => 0x7D2698;
        public long com_maxfps => 0x2CDD820;

        public long r_lightMap => 0x264A1A8;
        public long r_specularMap => 0x264A1C8;
        public long r_filmUseTweaks => 0x264A538;

        public long cg_brass => 0x7D25D8;
        public long r_fog => 0x264A138;
        public long r_glow => 0x264A500;
        public long r_detail => 0x264A190;
        public long r_detailMap => 0x264A1B8;

        public long cbuf_addtext => 0x0; // not tested yet
        public long nop_address => 0x0;

        public long profileMenuOption_safeAreaHorz => 0x7FE840;
        public long profileMenuOption_safeAreaVert => 0x7FE848;

    }
}
