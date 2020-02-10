namespace PersonGenerator.Builder.EmailBuilder
{
    public class EmptyEmailBuilder: IEmailBuilder
    {
        public string Build()
        {
            return null;
        }

        public string BuildWithParams(params string[] list)
        {
            return null;
        }
    }
}
