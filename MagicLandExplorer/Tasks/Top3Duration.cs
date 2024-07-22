
namespace MagicLandExplorer.Tasks
{
    public static class ShowTop3LongestDuration
    {
        public static void Execute(List<Category> categories)
        {
            var top3LongestDuration = categories.SelectMany(c => c.Destinations)
                                                .OrderByDescending(d => d.durationTime)
                                                .Take(3)
                                                .Select(d => new { d.Name, d.durationTime });

            Console.WriteLine("Top 3 longest-duration destinations:");
            foreach (var destination in top3LongestDuration)
            {
                Console.WriteLine($"\t{destination.Name} - {destination.durationTime} minutes");
            }
        }
    }
}
