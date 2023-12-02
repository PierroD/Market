using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface ISafeArea
    {

        int safeArea_horizontal { get; }
        int safeArea_vertical { get; }
        int safeArea_adjusted_horizontal { get; }
        int safeArea_adjusted_vertical { get; }

    }
}
