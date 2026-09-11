using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    /// <summary>
    /// Call of Duty Modern Warfare 2 - Multiplayer, 64-bit build (Steam update of September 2026).
    /// The executable is an AMD64 image with ImageBase 0x140000000 and ASLR enabled, so every
    /// address below is a RVA that has to be added to the live module base (COD.ModuleBase).
    /// The dvar_t value union also moved: +0x10 instead of +0xC (the name pointer is 8 bytes now).
    /// </summary>
    internal class iw4mp64 : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {
        public long dvar { get { return 0x10; } }

        public long cg_fov { get { return 0x6BD178; } }
        public long cg_fovMin { get { return 0x6BD180; } }
        public long cg_fovScale { get { return 0x6BD188; } }

        public long com_maxfps { get { return 0x1BD95A8; } }

        public long r_lightMap { get { return 0x8CC6870; } }
        public long r_specularMap { get { return 0x8CC6680; } }
        public long r_filmUseTweaks { get { return 0x8CC6750; } }

        public long cg_brass { get { return 0x6BD0B8; } }
        public long r_fog { get { return 0x8CC6A08; } }
        public long r_glow { get { return 0x8CC6B78; } }
        public long r_detail { get { return 0x8CC6BB0; } }
        public long r_detailMap { get { return 0x8CC66A8; } }

        // The external console relies on a 32-bit x86 remote-thread stub and a cbuf_addtext
        // address we have not located for the 64-bit build yet. Kept at 0 so the feature
        // reports itself as unavailable instead of writing garbage into the game.
        public long cbuf_addtext { get { return 0x0; } }
        public long nop_address { get { return 0x0; } }

        public long profileMenuOption_safeAreaHorz { get { return 0x6CCCA0; } }
        public long profileMenuOption_safeAreaVert { get { return 0x6CCCA8; } }
    }
}
