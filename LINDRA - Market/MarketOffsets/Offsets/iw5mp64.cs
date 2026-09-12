using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    /// <summary>
    /// Call of Duty Modern Warfare 3 - Multiplayer, 64-bit build (Steam update of September 2026).
    /// AMD64 image with ImageBase 0x140000000. The addresses below are RVA and are added to the
    /// live module base (COD.ModuleBase), which keeps them correct whether or not the loader
    /// relocates the image. The dvar_t value union is at +0x10, as in the 64-bit MW2 build.
    /// </summary>
    internal class iw5mp64 : IFovAndFps, IVisuals, IDisable, IConsole, ISafeArea
    {
        public long dvar { get { return 0x10; } }

        public long cg_fov { get { return 0x7D2688; } }
        public long cg_fovMin { get { return 0x7D2690; } }
        public long cg_fovScale { get { return 0x7D2698; } }

        public long com_maxfps { get { return 0x2CDD820; } }

        public long r_lightMap { get { return 0x264A1A8; } }
        public long r_specularMap { get { return 0x264A1C8; } }
        public long r_filmUseTweaks { get { return 0x264A538; } }

        public long cg_brass { get { return 0x7D25D8; } }
        public long r_fog { get { return 0x264A138; } }
        public long r_glow { get { return 0x264A500; } }
        public long r_detail { get { return 0x264A190; } }
        public long r_detailMap { get { return 0x264A1B8; } }

        // The external console relies on a 32-bit x86 remote-thread stub and a cbuf_addtext
        // address we have not located for the 64-bit build yet. Kept at 0 so the feature
        // reports itself as unavailable instead of writing garbage into the game.
        public long cbuf_addtext { get { return 0x0; } }
        public long nop_address { get { return 0x0; } }

        public long profileMenuOption_safeAreaHorz { get { return 0x7FE840; } }
        public long profileMenuOption_safeAreaVert { get { return 0x7FE848; } }
    }
}
