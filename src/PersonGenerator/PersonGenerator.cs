using System.Collections.Generic;
using PersonGenerator.Builder;

namespace PersonGenerator
{
    public class PersonGenerator
    {
        private readonly IPersonBuilder personBuilder;

        public PersonGenerator(GeneratorSettings settings)
        {
            personBuilder = new PersonBuilder(settings);
        }

        public List<Person> Generate(int count)
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                Person person = personBuilder.Build();
                people.Add(person);
            }

            return people;
        }
    }
}
