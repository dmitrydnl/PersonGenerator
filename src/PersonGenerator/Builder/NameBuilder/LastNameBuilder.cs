using System.Collections.Generic;
using PersonGenerator.WorkWithData;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.NameBuilder
{
    public class LastNameBuilder: INameBuilder
    {
        private readonly DataReader dataReader;

        public LastNameBuilder(GeneratorSettings settings)
        {
            dataReader = new DataReader(settings.Language, "last_name.txt");
        }

        public string Build()
        {
            List<string> names = dataReader.ReadToList();
            return ListRandom.GetRandomElement(names);
        }
    }
}
