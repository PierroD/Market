using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IFovAndFps
    {
        int dvar { get; }
        int cg_fov { get; }

        int cg_fovMin { get; }

        int cg_fovScale { get; }

        int com_maxfps { get; }
    }
}
