using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Player
    {
        //Variável de instância só de leitura
        private string name { get; }

        private double hp;

        //Variável de classe só de leitura
        public static double VidaMaxima { get; } = 100;

        public Player(string name, double hp)
        {
            this.name = name;
            this.hp = hp;

        }

        //Propriedade de classe só de leitura
        public string GetName()
        {
            return name;
        }

    }
}
