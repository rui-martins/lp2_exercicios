using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o jogador indicando o nome e hp
            Player jogador1 = new Player("Joao", 100);

            //Testa o programa
            Console.WriteLine("Player 1: " + jogador1.GetName());
        }
    }
}
