namespace TodoApi.Models
{
    public class NamedAPIResourceList<T>
    {
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
        public string Next { get; set; } = string.Empty;
        public string Previous { get; set; } = string.Empty;
        public List<T> Results { get; set; } = new List<T>();
    }
}
