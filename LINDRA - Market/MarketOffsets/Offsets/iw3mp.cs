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
        public int dvar { get { return 0xC; } }
        public int cg_fov { get { return 0x8C13D8; } }
        public int cg_fovScale { get { return 0x8BE2E4; } }
        public int com_maxfps { get { return 0x146EEF8; } }

        public int r_lightMap { get { return 0xD560A7C; } }
        public int r_specularMap { get { return 0xD560A60; } }
        public int r_filmUseTweaks { get { return 0xD560984; } }

        public int cg_brass { get { return 0x740644; } }
        public int r_fog { get { return 0xD560BF4; } }
        public int r_glow { get { return 0xD560A8C; } }
        public int r_detail { get { return 0xD560A78; } }
        public int r_detailMap { get { return 0xD560A78; } }

        public int cbuf_addtext { get { return 0x56C230; } }
        public int nop_address { get { return 0x0; } }

    }
}
