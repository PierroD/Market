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
        public long dvar => 0x18;
        public long cg_fov => 0xD52624;
        public long cg_fovMin => 0xCC19CC;

        public long cg_fovScale => 0xD52388;
        public long com_maxfps => 0X35A039C;

        public long r_lightMap => 0x48A4CAC;
        public long r_specularMap => 0x48A4C14;
        public long r_filmUseTweaks => 0x48A4A3C;

        public long cg_brass => 0xCC1A14;
        public long r_fog => 0x48A4F6C;
        public long r_glow => 0x0;
        public long r_detail => 0x0;
        public long r_detailMap => 0x0;
        public long cbuf_addtext => 0x56EF70;
        public long nop_address => 0x8B5A37;
    }
}
