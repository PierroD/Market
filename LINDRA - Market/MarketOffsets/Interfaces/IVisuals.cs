using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IVisuals
    {
        long r_lightMap { get; }
        long r_specularMap { get; }
        long r_filmUseTweaks { get; }

    }
}
