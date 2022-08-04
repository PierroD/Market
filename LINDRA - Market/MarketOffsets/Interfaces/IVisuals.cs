using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IVisuals
    {
        int r_lightMap { get; }
        int r_specularMap { get; }
        int r_filmUseTweaks { get; }

    }
}
