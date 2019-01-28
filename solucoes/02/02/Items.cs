using System;

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
