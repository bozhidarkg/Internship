using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace BasketballPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the path to the JSON file containing the players: ");
            String jsonPath = Console.ReadLine();
            Console.Write("Please enter maximum number of years the player has played in the league to qualify: ");
            short numberOfYears = short.Parse(Console.ReadLine());
            Console.Write("Please enter a number representing the minimum rating the player should have to qualify: ");
            short minRating = short.Parse(Console.ReadLine());
            Console.Write("Please enter the  path to the CSV  file: ");
            String pathToFile = Console.ReadLine();
            Console.WriteLine();

            String rawJson = rawJson = File.ReadAllText(jsonPath);
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(rawJson);

            StringBuilder sb = new StringBuilder();
            sb.Append("Name,Rating" + System.Environment.NewLine);

            players = players.OrderByDescending(p => p.Rating).ToList();
            foreach (Player pl in players)
            {
                if (pl.Rating >= minRating && (2019 - pl.PlayingSince) <= numberOfYears)
                {
                    sb.Append(pl.Name + ", " + pl.Rating + System.Environment.NewLine);
                }
            }

            File.WriteAllText(pathToFile, sb.ToString());
        }
    }
}
