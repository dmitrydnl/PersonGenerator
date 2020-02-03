using System.Collections.Generic;
using PersonGenerator.WorkWithData;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.NameBuilder
{
    public class MiddleNameBuilder: INameBuilder
    {
        private readonly DataReader dataReader;

        public MiddleNameBuilder(GeneratorSettings settings)
        {
            dataReader = new DataReader(settings.Language, "middle_name.txt");
        }

        public string Build()
        {
            List<string> names = dataReader.ReadToList();
            return ListRandom.GetRandomElement(names);
        }
    }
}
