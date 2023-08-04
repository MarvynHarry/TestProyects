namespace TodoApi.Models
{
    public class Named
    {
        public int Count { get; set; }
        public string Next { get; set; } = string.Empty;
        public string Previous { get; set; } = string.Empty;
        public List<NamedAPIResource> Results { get; set; } = new List<NamedAPIResource>();
    }
}
