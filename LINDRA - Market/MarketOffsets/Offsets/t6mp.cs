using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketOffsets.Interfaces;

namespace MarketOffsets.Offsets
{
    internal class t6mp : IConsole
    {
        public long cbuf_addtext => 0x5BDF70;
        public long nop_address => 0x8C90DA;

    }
}
