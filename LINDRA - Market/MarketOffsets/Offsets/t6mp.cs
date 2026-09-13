using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class t6mp : IConsole, IFovAndFps, IVisuals, IDisable
    {
        public long dvar => 0x18;
        public long cg_fov => 0x10647BC;

        public long cg_fovMin => 0xFCC73C;

        public long cg_fovScale => 0x1062DC0;

        public long com_maxfps => 0x250642C;

        public long r_lightMap => 0x0;
        public long r_specularMap => 0x34C7238;
        public long r_filmUseTweaks => 0x34C7060;

        public long cg_brass => 0x0;
        public long r_fog => 0x34C74EC;
        public long r_glow => 0x0;
        public long r_detail => 0x0;
        public long r_detailMap => 0x0;
 
        public long cbuf_addtext => 0x0; // 0x6BAD90;
        public long nop_address => 0x0; // 0x8C90DA;

    }
}
