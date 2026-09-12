using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IConsole
    {
        long cbuf_addtext { get; }
        long nop_address { get; }
    }
}
