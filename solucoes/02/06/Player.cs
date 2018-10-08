
namespace _03
{
    /// <summary>
    /// Classe Player: 
    /// </summary>
    class Player
    {

        /// <summary>
        /// Declaração de variáveis de instância.
        /// </summary>
        private readonly double hp;
        private readonly string name;

        /// <summary>
        /// Declaração de variável de classe só de leitura
        /// </summary>
        private readonly static int numberOfWeapons = 2;

        /// <summary>
        /// Propriedade (de instância) só de leitura.
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// Propriedade de classe só de leitura.
        /// </summary>
        public static double VidaMaxima { get; } = 100;


        /// <summary>
        /// Construtor que inicializa as variáveis relevantes.
        /// </summary>
        /// <param name="name">Indica o nome do jogador</param>
        /// <param name="hp">É escolhido o hp do jogador sendo o 
        /// máximo 100</param>
        /// <param name="score">Indica o score do jogador</param>
        public Player(string name, double hp, int score)
        {
            this.name = name;
            this.hp = hp;
            this.Score = score;
        }

        /// <summary>
        /// Método apenas para testar o programa na class Program.cs
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

    }
}
