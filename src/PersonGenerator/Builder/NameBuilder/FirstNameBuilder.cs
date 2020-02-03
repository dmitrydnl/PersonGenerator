using PersonGenerator.WorkWithData;

namespace PersonGenerator.Builder.NameBuilder
{
    public class FirstNameBuilder: INameBuilder
    {
        private readonly GeneratorSettings settings;
        private readonly DataReader dataReader;

        public FirstNameBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
            dataReader = new DataReader(settings.Language, "first_name.txt");
        }

        public string Build()
        {
            return "FirstName";
        }
    }
}
