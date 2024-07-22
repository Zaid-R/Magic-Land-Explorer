using Newtonsoft.Json;

namespace MagicLandExplorer
{
    public class Category
    {
        [JsonProperty("category")]
        public string Name { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
