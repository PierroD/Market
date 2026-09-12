using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IDisable
    {
        long cg_brass { get; }
        long r_fog { get; }
        long r_glow { get; }
        long r_detail { get; }
        long r_detailMap { get; }
    }
}
