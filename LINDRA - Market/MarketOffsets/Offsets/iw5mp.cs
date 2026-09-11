using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class iw5mp : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {
        public long dvar { get { return 0xC; } }
        public long cg_fov { get { return 0xB0C738; } }

        public long cg_fovMin { get { return 0x8FC8D8; } }

        public long cg_fovScale { get { return 0xB065C8; } }
        public long com_maxfps { get { return 0x1CF0B84; } }

        public long r_lightMap { get { return 0x5FC07C8; } }
        public long r_specularMap { get { return 0x5FC07A8; } }
        public long r_filmUseTweaks { get { return 0x5FC0698; } }

        public long cg_brass { get { return 0x8FC90C; } }
        public long r_fog { get { return 0x5FC091C; } }
        public long r_glow { get { return 0x5FC07D4; } }
        public long r_detail { get { return 0x5FC07C4; } }
        public long r_detailMap { get { return 0x5FC0654; } }

        public long cbuf_addtext { get { return 0x545650; } }
        public long nop_address { get { return 0x0; } }

        public long profileMenuOption_safeAreaHorz { get { return 0x132D214; } }
        public long profileMenuOption_safeAreaVert { get { return 0x132AD1C; } }

    }
}
