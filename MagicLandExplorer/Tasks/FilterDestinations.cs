
namespace MagicLandExplorer.Tasks
{
    public static class ShowFilteredDestinations
    {
        public static void Execute(List<Category> categories)
        {
            var filteredDestinations = categories.SelectMany(c => c.Destinations)
                                                 .Where(d => d.durationTime < 100)
                                                 .Select(d => d);

            Console.WriteLine("Destinations with duration less than 100 minutes:");
            foreach (var d in filteredDestinations)
            {
                Console.WriteLine($"\t{d.durationTime} minutes | {d.Name}");
            }
        }
    }
}
