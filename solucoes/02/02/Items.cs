using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02 {

    // Items enumeration
    [Flags]
    public enum Items {

        Food = 1,
        Guns = 2,
        Enemy = 4,
        Trap = 8
    }
}
