using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw4mp : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {

        public long dvar => 0x10;
        public long cg_fov => 0x6BD178;
        public long cg_fovMin => 0x6BD180;

        public long cg_fovScale => 0x6BD188;

        public long com_maxfps => 0x1BD95A8;

        public long r_lightMap => 0x8CC6870;
        public long r_specularMap => 0x8CC6680;
        public long r_filmUseTweaks => 0x8CC6750;

        public long cg_brass => 0x06BD0B8;
        public long r_fog => 0x8CC6A08;
        public long r_glow => 0x8CC6B78;
        public long r_detail => 0x8CC6BB0;
        public long r_detailMap => 0x8CC66A8;

        public long cbuf_addtext => 0x0; // 0x1E6DC0 need to update the ExternalConsole.cs to use this new address, but for now, we can leave it as 0x0 since we are not using it in the current implementation.
        public long nop_address => 0x0; // didn't change

        public long profileMenuOption_safeAreaHorz => 0x6CCCA0;
        public long profileMenuOption_safeAreaVert => 0x6CCCA8;

    }
}
