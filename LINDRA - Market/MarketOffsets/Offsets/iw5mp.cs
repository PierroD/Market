using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw5mp : IFovAndFps, IVisuals, IDisable, IConsole
    {
        public int dvar { get { return 0xC; } }
        public int cg_fov { get { return 0x5FC091C; } }
        public int com_maxfps { get { return 0x1CF0B84; } }

        public int r_lightMap { get { return 0x5FC07C8; } }
        public int r_specularMap { get { return 0x5FC07A8; } }
        public int r_filmUseTweaks { get { return 0x5FC0698; } }

        public int cg_brass { get { return 0x8FC90C; } }
        public int r_fog { get { return 0x5FC091C; } }
        public int r_glow { get { return 0x5FC07D4; } }
        public int r_detail { get { return 0x5FC07C4; } }
        public int r_detailMap { get { return 0x5FC0654; } }

        public int cbuf_addtext { get { return 0x545650; } }
        public int nop_address { get { return 0x0; } }

    }
}
