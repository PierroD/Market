using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw4mp : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {
        public long dvar { get { return 0xC; } }
        public long cg_fov { get { return 0xAAC1F8; } }
        public long cg_fovMin { get { return 0x88CB54; } }

        public long cg_fovScale { get { return 0xAA6098; } }

        public long com_maxfps { get { return 0x1B90730; } }

        public long r_lightMap { get { return 0x695D9C8; } }
        public long r_specularMap { get { return 0x695D9AC; } }
        public long r_filmUseTweaks { get { return 0x695D898; } }

        public long cg_brass { get { return 0x88E20C; } }
        public long r_fog { get { return 0x695DB18; } }
        public long r_glow { get { return 0x695D9D0; } }
        public long r_detail { get { return 0x695D9C4; } }
        public long r_detailMap { get { return 0x695D860; } }

        public long cbuf_addtext { get { return 0x563BE0; } }
        public long nop_address { get { return 0x0; } }

        public long profileMenuOption_safeAreaHorz { get { return 0x10F5984; } }
        public long profileMenuOption_safeAreaVert { get { return 0x10F4600; } }

    }
}
