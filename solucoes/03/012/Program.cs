using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {

            // Abrir ficheiro com nomes os de jogos e colocar num array de strings
            string[] games = File.ReadAllLines("videogames.txt");

            // Dicionário onde vai ser colocado os resultados da pesquisa
            Dictionary<string, ICollection<string>> dicGames = 
                new Dictionary<string, ICollection<string>>();

            // Ciclo de procuras, infinito
            while (true)
            {
                // Cronómetro
                Stopwatch stopwatch;

                // String a procurar
                string searchString;

                // Resultados da procura, têm de ser enumeráveis e contáveis
                ICollection<string> results;

                // Solicitar string de procura, transformar em minúsculas para
                // facilitar comparação mais à frente
                Console.Write("Search for? ");
                searchString = Console.ReadLine().ToLower();

                // Começar contagem do tempo
                stopwatch = Stopwatch.StartNew();

                // Verificar se já foi feita a pesquisa antes, se sim então 
                // mostra o resultado contido no dicionário.
                if (dicGames.ContainsKey(searchString))
                {
                    // Atribuir o valor contigo na key do dicionário ao 
                    // resultado
                    results = dicGames[searchString];

                }
                // Caso contrario faz a pesquisa no array de strings
                else
                {
                    // Criar uma nova lista para colocar os resultados
                    results = new List<string>();

                    // Procura no array de strings se há contido a searchString
                    foreach (string game in games)
                    {
                        // Verifica se a string começa com # ou se está vazia e
                        // passa a proxima iteração do foreach
                        if (game.StartsWith("#") || String.IsNullOrEmpty(game))
                        {
                            continue;
                        }
                        if (game.ToLower().Contains(searchString))
                        {
                            results.Add(game);
                        }
                    }

                    // Adicionar resultados não repetidos ao dicionário
                    if (!dicGames.ContainsKey(searchString))
                        dicGames.Add(searchString, results);
                }

                // Parar o cronómetro
                stopwatch.Stop();

                // Mostrar quantos resultados foram obtidos e o tempo que 
                // demorou a fazer a pesquisa da mesma
                Console.WriteLine($"Time to find {results.Count} games " +
                        $"was {stopwatch.Elapsed}");

                // Pergunta e mostra todos os jogos relacionados com a pesquisa
                Console.WriteLine("Do you wish to see a list of the games " +
                    "found? (Y/N)");

                // Ciclo para garantir que só aceita Y ou N
                bool answer = false;
                while (!answer)
                {
                    string temp = Console.ReadLine().ToLower();
                    switch (temp)
                    {
                        case "y":
                            Console.WriteLine($"Games from the search " +
                                $"{searchString} : ");

                            // Procura todos os jogos dentro do value do 
                            // dicionário com a key introduzida pelo utilizador
                            foreach (string game in dicGames.GetValueOrDefault(searchString))
                            {
                                Console.WriteLine(game);
                            }
                            answer = true;
                            break;
                        case "n":
                            answer = true;
                            break;
                        default:
                            continue;
                    }
                }
            }
        }
    }
}
