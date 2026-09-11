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
        public long dvar { get { return 0x18; } }
        public long cg_fov { get { return 0x111810C; } }
        public long cg_fovMin { get { return 0x108008C; } }

        public long cg_fovScale { get { return 0x1116710; } }
        public long com_maxfps { get { return 0x25BA4B0; } }

        public long r_lightMap { get { return 0x0; } }
        public long r_specularMap { get { return 0x342AF10; } }
        public long r_filmUseTweaks { get { return 0x342AD38; } }

        public long cg_brass { get { return 0x0; } }
        public long r_fog { get { return 0x342B1C4; } }
        public long r_glow { get { return 0x0; } }
        public long r_detail { get { return 0x0; } }
        public long r_detailMap { get { return 0x0; } }
        public long cbuf_addtext { get { return 0X4C7120; } }
        public long nop_address { get { return 0X0; } }
    }
}
