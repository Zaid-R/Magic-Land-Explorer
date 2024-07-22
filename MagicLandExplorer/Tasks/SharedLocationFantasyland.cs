
namespace MagicLandExplorer.Tasks
{
    public static class FindAndListCategoriesWithSharedLocationFantasyland
    {
        public static void Execute(List<Category> categories)
        {
            var result = categories.Where(c => c.Destinations.Any(d => d.Location == "Fantasyland"))
                                   .Select(c => c.Name).ToList();

            Console.WriteLine("Categories that have \"Fantasyland\" as a shared location:");
            foreach (var name in result)
            {
                Console.WriteLine($"\t{name}");
            }
        }
    }
}
