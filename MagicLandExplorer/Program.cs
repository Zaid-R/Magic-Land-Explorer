using MagicLandExplorer.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    public class Program 
    {
        static void Main(string[] args)
        {
            string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            string jsonFilePath = Path.Combine(dataDir, "MagicLandData.json");
            if (!File.Exists(jsonFilePath))
            {
                Console.WriteLine("MagicLandData.json is not found");
                return;
            }
            string json = File.ReadAllText(jsonFilePath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json)!;
            

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1- Show filtered destinations (duration < 100 minutes)");
                Console.WriteLine("2- Show destination with the longest duration");
                Console.WriteLine("3- Sort destinations by name");
                Console.WriteLine("4- Show top 3 longest-duration destinations");
                Console.WriteLine("5- Find and list all categories that have \"Fantasyland\" as a shared location");
                Console.WriteLine("6- Exit");
                string choice = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        ShowFilteredDestinations.Execute(categories);
                        break;
                    case "2":
                        ShowLongestDuration.Execute(categories);
                        break;
                    case "3":
                        SortDestinationsByName.Execute(categories);
                        break;
                    case "4":
                        ShowTop3LongestDuration.Execute(categories);
                        break;
                    case "5":
                        FindAndListCategoriesWithSharedLocationFantasyland.Execute(categories);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
        
    }
}
