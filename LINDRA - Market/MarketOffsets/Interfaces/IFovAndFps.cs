using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IFovAndFps
    {
        long dvar { get; }
        long cg_fov { get; }

        long cg_fovMin { get; }

        long cg_fovScale { get; }

        long com_maxfps { get; }
    }
}
