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
        public int dvar { get { return 0xC; } }
        public int cg_fov { get { return 0xD52624; } }
        public int com_maxfps { get { return 0X35A039C; } }

        public int r_lightMap { get { return 0x48A4CAC; } }
        public int r_specularMap { get { return 0x48A4C14; } }
        public int r_filmUseTweaks { get { return 0x48A4A3C; } }

        public int cg_brass { get { return 0xCC1A14; } }
        public int r_fog { get { return 0x48A4F6C; } }
        public int r_glow { get { return 0x0; } }
        public int r_detail { get { return 0x0; } }
        public int r_detailMap { get { return 0x0; } }
        public int cbuf_addtext { get { return 0x56EF70; } }
        public int nop_address { get { return 0x8B5A37; } }
    }
}
