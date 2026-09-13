using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw4sp : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {

        public long dvar => 0x10;
        public long cg_fov => 0x51E1A8;
        public long cg_fovMin => 0x51E1B0;

        public long cg_fovScale => 0x51E1B8;

        public long com_maxfps => 0x1325C28;

        public long r_lightMap => 0x4116148;
        public long r_specularMap => 0x4116428;
        public long r_filmUseTweaks => 0x4116028;

        public long cg_brass => 0x51E118;
        public long r_fog => 0x4116300;
        public long r_glow => 0x41163E0;
        public long r_detail => 0x4116400;
        public long r_detailMap => 0x4116450;

        public long cbuf_addtext => 0x0; // 0x1EE890 need to update the ExternalConsole.cs to use this new address, but for now, we can leave it as 0x0 since we are not using it in the current implementation.
        public long nop_address => 0x0; // didn't change

        public long profileMenuOption_safeAreaHorz => 0x5DF530;
        public long profileMenuOption_safeAreaVert => 0x5DF538;

    }
}
