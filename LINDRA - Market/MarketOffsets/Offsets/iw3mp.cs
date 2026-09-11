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
        public long dvar { get { return 0xC; } }
        public long cg_fov { get { return 0x8C13D8; } }
        public long cg_fovMin { get { return 0x740624; } }
        public long cg_fovScale { get { return 0x8BE2E4; } }
        public long com_maxfps { get { return 0x146EEF8; } }

        public long r_lightMap { get { return 0xD560A7C; } }
        public long r_specularMap { get { return 0xD560A60; } }
        public long r_filmUseTweaks { get { return 0xD560984; } }

        public long cg_brass { get { return 0x740644; } }
        public long r_fog { get { return 0xD560BF4; } }
        public long r_glow { get { return 0xD560A8C; } }
        public long r_detail { get { return 0xD560A78; } }
        public long r_detailMap { get { return 0xD560A78; } }

        public long cbuf_addtext { get { return 0x56C230; } }
        public long nop_address { get { return 0x0; } }

    }
}
