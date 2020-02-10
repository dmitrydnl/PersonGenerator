namespace PersonGenerator.Builder.EmailBuilder
{
    public interface IEmailBuilder
    {
        public string Build();
        public string BuildWithParams(params string[] list);
    }
}
