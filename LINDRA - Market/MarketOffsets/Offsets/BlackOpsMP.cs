using MarketOffsets.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Offsets
{
    internal class BlackOpsMP : IFovAndFps, IVisuals, IDisable, IConsole
    {
        public long dvar { get { return 0x18; } }
        public long cg_fov { get { return 0xD52624; } }
        public long cg_fovMin { get { return 0xCC19CC; } }

        public long cg_fovScale { get { return 0xD52388; } }
        public long com_maxfps { get { return 0X35A039C; } }

        public long r_lightMap { get { return 0x48A4CAC; } }
        public long r_specularMap { get { return 0x48A4C14; } }
        public long r_filmUseTweaks { get { return 0x48A4A3C; } }

        public long cg_brass { get { return 0xCC1A14; } }
        public long r_fog { get { return 0x48A4F6C; } }
        public long r_glow { get { return 0x0; } }
        public long r_detail { get { return 0x0; } }
        public long r_detailMap { get { return 0x0; } }
        public long cbuf_addtext { get { return 0x56EF70; } }
        public long nop_address { get { return 0x8B5A37; } }
    }
}
