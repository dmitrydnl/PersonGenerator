namespace PersonGenerator.Builder.EmailBuilder
{
    internal interface IEmailBuilder
    {
        public string Build();
        public string BuildWithParams(params string[] list);
    }
}
