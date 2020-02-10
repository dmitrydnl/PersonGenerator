using System.Collections.Generic;
using PersonGenerator.WorkWithData;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.NameBuilder
{
    internal class MiddleNameBuilder : INameBuilder
    {
        private readonly DataReader dataReader;

        internal MiddleNameBuilder(GeneratorSettings settings)
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
