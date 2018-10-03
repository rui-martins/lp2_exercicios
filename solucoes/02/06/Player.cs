
namespace _03
{
    /// <summary>
    /// Classe Player: 
    /// </summary>
    class Player
    {

        /// <summary>
        /// Criação de variáveis de instância.
        /// Definem a informação contida numa classe. 
        /// São declaradas no corpo da classe, mas fora de qualquer método,
        /// estando acessíveis a todos os métodos da classe.
        /// Sendo hp e name variáveis de instância "normal", currentScore
        /// trata-se de uma variável de instância só de leitura.
        /// </summary>
        private double hp;
        private string name;
        readonly int currentScore;

        //confirmar ?? 
        /// <summary>
        /// Propriedade (de instância) só de leitura.
        /// Fornece a possibilidade de ler, graver ou calcular algo, neste caso
        /// sendo apenas de leitura iremos obter apenas o score do jogador.
        /// </summary>
        public int Score { get { return currentScore; } }

        /// <summary>
        /// Propriedade de classe só de leitura.
        /// O jogador só pode ter hp máximo de 100, sendo uma propriedade de 
        /// classe só de leitura, não permite ser alterado o hp máximo.
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
