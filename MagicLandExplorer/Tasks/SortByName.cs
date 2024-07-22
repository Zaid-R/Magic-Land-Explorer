
namespace MagicLandExplorer.Tasks
{
    public static class SortDestinationsByName
    {
        public static void Execute(List<Category> categories)
        {
            var sortedDestinations = categories.SelectMany(c => c.Destinations)
                                               .OrderBy(d => d.Name)
                                               .Select(d => d.Name);

            Console.WriteLine("Sorted destinations by name:");
            foreach (var name in sortedDestinations)
            {
                Console.WriteLine($"\t{name}");
            }
        }
    }
}
