
namespace MagicLandExplorer.Tasks
{
    public static class ShowLongestDuration
    {
        public static void Execute(List<Category> categories)
        {
            var longestDurationDestination = categories.SelectMany(c => c.Destinations)
                                                        .OrderByDescending(d => d.durationTime)
                                                        .FirstOrDefault();

            if (longestDurationDestination != null)
            {
                Console.WriteLine($"Destination with the longest duration: {longestDurationDestination.Name}");
            }
        }
    }
}
