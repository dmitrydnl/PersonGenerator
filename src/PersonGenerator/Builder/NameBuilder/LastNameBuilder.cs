namespace PersonGenerator.Builder.NameBuilder
{
    public class LastNameBuilder: INameBuilder
    {
        private readonly GeneratorSettings settings;

        public LastNameBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
        }

        public string Build()
        {
            return "LastName";
        }
    }
}
