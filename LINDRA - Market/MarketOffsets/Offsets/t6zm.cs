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
        public long cg_fov => 0x111810C;
        public long cg_fovMin => 0x108008C;

        public long cg_fovScale => 0x1116710;
        public long com_maxfps => 0x25BA4B0;

        public long r_lightMap => 0x0;
        public long r_specularMap => 0x342AF10;
        public long r_filmUseTweaks => 0x342AD38;

        public long cg_brass => 0x0;
        public long r_fog => 0x342B1C4;
        public long r_glow => 0x0;
        public long r_detail => 0x0;
        public long r_detailMap => 0x0;
        public long cbuf_addtext => 0x4C7120;
        public long nop_address => 0x0;
    }
}
