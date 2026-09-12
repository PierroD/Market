using MarketOffsets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Offsets
{
    internal class iw3mp : IFovAndFps, IVisuals, IDisable, IConsole
    {
        public long dvar => 0xC;
        public long cg_fov => 0x8C13D8;
        public long cg_fovMin => 0x740624;
        public long cg_fovScale => 0x8BE2E4;
        public long com_maxfps => 0x146EEF8;

        public long r_lightMap => 0xD560A7C;
        public long r_specularMap => 0xD560A60;
        public long r_filmUseTweaks => 0xD560984;

        public long cg_brass => 0x740644;
        public long r_fog => 0xD560BF4;
        public long r_glow => 0xD560A8C;
        public long r_detail => 0xD560A78;
        public long r_detailMap => 0xD560A78;

        public long cbuf_addtext => 0x56C230;
        public long nop_address => 0x0;

    }
}
