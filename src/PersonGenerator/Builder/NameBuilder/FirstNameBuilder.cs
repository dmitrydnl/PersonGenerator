namespace PersonGenerator.Builder.NameBuilder
{
    public class FirstNameBuilder: INameBuilder
    {
        private readonly GeneratorSettings settings;

        public FirstNameBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
        }

        public string Build()
        {
            return "FirstName";
        }
    }
}
