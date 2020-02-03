using System.Collections.Generic;
using PersonGenerator.WorkWithData;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.NameBuilder
{
    public class FirstNameBuilder: INameBuilder
    {
        private readonly DataReader dataReader;

        public FirstNameBuilder(GeneratorSettings settings)
        {
            dataReader = new DataReader(settings.Language, "first_name.txt");
        }

        public string Build()
        {
            List<string> names = dataReader.ReadToList();
            return ListRandom.GetRandomElement(names);
        }
    }
}
