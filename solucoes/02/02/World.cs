using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02 {
    class World {

        // World dimensions
        private int x, y;

        // Random variable
        private Random rnd;
        
        // A multidimensional array of items
        private Items[,] items;

        // A char to be switched by its bit assigned value
        private char space;

        // Constructor
        public World(int x, int y) {

            this.x = x;
            this.y = y;

            rnd = new Random();

            items = new Items[x, y];

            space = (char)0x20;
        }

        // Creates the world according to the given coordinates
        public void CreateWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    items[j, i] = (Items)space;

                    PopulateSlot(j, i);

                    // Debugging (gives a decimal value instead of the Items name)
                    /* Console.WriteLine($"[{i},{j}] - Contains: {items[j, i]}" +
                        $" - Character: {(char)items[j, i]}"); */
                }
            }
        }

        // Draws the World
        public void RenderWorld() {

            for (int i = 0; i < y; i++) {

                for (int j = 0; j < x; j++) {

                    Console.Write((char)items[i, j]);
                }
                Console.WriteLine();
            }
        }

        // Populates the world by calling 'NextDouble' 4 times in each slot
        private void PopulateSlot(int x, int y) {

            if (rnd.NextDouble() <= 0.01) {

                items[x, y] |= Items.Food;
            }

            if (rnd.NextDouble() <= 0.005) {

                items[x, y] |= Items.Guns;
            }

            if (rnd.NextDouble() <= 0.005) {

                items[x, y] |= Items.Enemy;
            }

            if (rnd.NextDouble() <= 0.003) {

                items[x, y] |= Items.Trap;
            }
        }
    }
}
