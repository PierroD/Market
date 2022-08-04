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
        public int cg_fov { get { return 0xAAC278; } }
        public int com_maxfps { get { return 0x1B907B0; } }

        public int r_lightMap { get { return 0x695DA48; } }
        public int r_specularMap { get { return 0x695DA2C; } }
        public int r_filmUseTweaks { get { return 0x695D918; } }
       
        public int cg_brass { get { return 0x88E28C; } }
        public int r_fog { get { return 0x695DB98; } }
        public int r_glow { get { return 0x695DA50; } }
        public int r_detail { get { return 0x695DA44; } }
        public int r_detailMap { get { return 0x695D8E0; } }

        public int cbuf_addtext { get { return 0x563D10; } }
        public int nop_address { get { return 0x0; } }

    }
}
