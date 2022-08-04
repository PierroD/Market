using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOffsets.Interfaces
{
    internal interface IConsole
    {
        int cbuf_addtext { get; }
        int nop_address { get; }
    }
}
