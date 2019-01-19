using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02 {
    class Input {

        // Empty Constructor
        public Input() { }

        // Retrieves the x value of the world
        public int GetX() {

            Console.Write("X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            return x;
        }

        // Retrieves the y value of the world
        public int GetY() {

            Console.Write("Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            return y;
        }
    }
}
