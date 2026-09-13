using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class t6sp : IConsole, IFovAndFps, IVisuals, IDisable
    {
        public long dvar => 0x18;
        public long cg_fov => 0x2C75F3C;

        public long cg_fovMin => 0x2BE1924;

        public long cg_fovScale => 0x2C75E2C;

        public long com_maxfps => 0x27C5480;

        public long r_lightMap => 0x0;
        public long r_specularMap => 0x32D00A8;
        public long r_filmUseTweaks => 0x32CFED0;

        public long cg_brass => 0x0;
        public long r_fog => 0x32D035C;
        public long r_glow => 0x0;
        public long r_detail => 0x0;
        public long r_detailMap => 0x0;
 
        public long cbuf_addtext => 0x0; // 0x6D0EE0  
        public long nop_address => 0x0; 

    }
}
