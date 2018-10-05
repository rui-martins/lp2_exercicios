
namespace _03
{
    /// <summary>
    /// Classe Player: 
    /// </summary>
    class Player
    {

        /// <summary>
        /// Criação de variáveis de instância.
        /// </summary>
        readonly private double hp;
        readonly private string name;

        /// <summary>
        /// Criação de variável de classe só de leitura
        /// </summary>
        private static int numberOfWeapons = 2;

        /// <summary>
        /// Propriedade (de instância) só de leitura.
        /// </summary>
        public int Score { get; }

        /// <summary>
        /// Propriedade de classe só de leitura.
        /// </summary>
        public static double VidaMaxima { get; } = 100;


        /// <summary>
        /// Constructor que inicializa as variáveis relevantes.
        /// </summary>
        /// <param name="name">Indica o nome do jogador</param>
        /// <param name="hp">é escolhido o hp do jogador sendo o 
        /// máximo 100</param>
        public Player(string name, double hp)
        {
            this.name = name;
            this.hp = hp;
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
