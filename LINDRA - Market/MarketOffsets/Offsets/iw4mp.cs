using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw4mp : IFovAndFps, IVisuals, IDisable, IConsole
    {
        public int dvar { get { return 0xC; } }
        public int cg_fov { get { return 0xAAC1F8; } }

        public int cg_fovScale { get { return 0xAA6098; } }

        public int com_maxfps { get { return 0x1B90730; } }

        public int r_lightMap { get { return 0x695D9C8; } }
        public int r_specularMap { get { return 0x695D9AC; } }
        public int r_filmUseTweaks { get { return 0x695D898; } }
       
        public int cg_brass { get { return 0x88E20C; } }
        public int r_fog { get { return 0x695DB18; } }
        public int r_glow { get { return 0x695D9D0; } }
        public int r_detail { get { return 0x695D9C4; } }
        public int r_detailMap { get { return 0x695D860; } }

        public int cbuf_addtext { get { return 0x563BE0; } }
        public int nop_address { get { return 0x0; } }

    }
}
