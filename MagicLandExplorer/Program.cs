using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace MagicLandExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "MagicLandData.json");
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("JSON file not found at: " + jsonFilePath);
                return;
            }
            string json = File.ReadAllText("data/MagicLandData.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            Console.WriteLine("Welcome to Magic Land Explorer!");
            Console.WriteLine("1- Show filtered destinations (duration < 100 minutes)");
            Console.WriteLine("2- Show destination with longest duration");
            Console.WriteLine("3- Sort destinations by name");
            Console.WriteLine("4- Show top 3 longest duration destinations");
            Console.Write("Select an option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var shortDestinations = FilterDestinations.GetDestinationsWithShortDuration(categories, 100);
                    shortDestinations.ForEach(Console.WriteLine);
                    break;
                case 2:
                    var longestDestination = LongestDuration.GetLongestDurationDestination(categories);
                    Console.WriteLine(longestDestination);
                    break;
                case 3:
                    var sortedDestinations = SortByName.GetSortedDestinationsByName(categories);
                    sortedDestinations.ForEach(Console.WriteLine);
                    break;
                case 4:
                    var top3Destinations = Top3Duration.GetTop3LongestDurationDestinations(categories);
                    top3Destinations.ForEach(d => Console.WriteLine($"{d.Name}: {d.Duration} minutes"));
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

