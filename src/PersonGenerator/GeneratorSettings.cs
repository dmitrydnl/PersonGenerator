namespace PersonGenerator
{
    public class GeneratorSettings
    {
        public Languages Language { get; set; }
        public bool FirstName { get; set; }
        public bool MiddleName { get; set; }
        public bool LastName { get; set; }
        public bool Age { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public bool Email { get; set; }
    }
}
