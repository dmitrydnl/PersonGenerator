using PersonGenerator.WorkWithData;

namespace PersonGenerator.Builder.NameBuilder
{
    public class LastNameBuilder: INameBuilder
    {
        private readonly GeneratorSettings settings;
        private readonly DataReader dataReader;

        public LastNameBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
            dataReader = new DataReader(settings.Language, "last_name.txt");
        }

        public string Build()
        {
            return "LastName";
        }
    }
}
