using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Cria o jogador indicando o nome, hp e score inicial
            Player jogador1 = new Player("Joao", 100, 0);

            ///Testa o programa
            Console.WriteLine("Player 1: " + jogador1.GetName());
        }
    }
}
