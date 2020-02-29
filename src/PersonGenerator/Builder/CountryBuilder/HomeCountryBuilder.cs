using System.Collections.Generic;
using PersonGenerator.WorkWithData;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.CountryBuilder
{
    public class HomeCountryBuilder : ICountryBuilder
    {
        private readonly DataReader dataReader;

        internal HomeCountryBuilder(GeneratorSettings settings)
        {
            dataReader = new DataReader(settings.Language, "country.txt");
        }

        public string Build()
        {
            List<string> countries = dataReader.ReadToList();
            return ListRandom.GetRandomElement(countries);
        }
    }
}
