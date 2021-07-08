using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class BinarySwapNibble
    {
        public static int SwapNibble(int x)
        {
            return ((4 << x) | (x >> 4));
        }
    }
}
