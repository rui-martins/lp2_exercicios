using System;

namespace _02 {
    class Program {

        // Main method calls Input class
        // and initiates a World with the retrieved values
        static void Main(string[] args) {

            int x = Convert.ToInt32(args[0]);
            int y = Convert.ToInt32(args[1]);

            World myWorld = new World(x, y);
            myWorld.CreateWorld();
            myWorld.RenderWorld();
        }
    }
}
