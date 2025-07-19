using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Enums
{
    [Flags]
    internal enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8, 
    }
}
