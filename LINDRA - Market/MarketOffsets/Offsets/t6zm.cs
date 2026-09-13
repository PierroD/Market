using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class t6zm : IFovAndFps, IVisuals, IDisable, IConsole
    {
        public long dvar => 0x18;
        public long cg_fov => 0x106284C;
        public long cg_fovMin => 0xFCA7CC;

        public long cg_fovScale => 0x1060E50;
        public long com_maxfps => 0x25044AC;

        public long r_lightMap => 0x0;
        public long r_specularMap => 0x34C52B8;
        public long r_filmUseTweaks => 0x34C50E0;

        public long cg_brass => 0x0;
        public long r_fog => 0x34C556C;
        public long r_glow => 0x0;
        public long r_detail => 0x0;
        public long r_detailMap => 0x0;
        public long cbuf_addtext => 0x0; // 6BBE40
        public long nop_address => 0x0;
    }
}
