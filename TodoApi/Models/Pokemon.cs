namespace TodoApi.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Base_experience { get; set; }
        public int Height { get; set; }
        public bool Is_default { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
    }
}
