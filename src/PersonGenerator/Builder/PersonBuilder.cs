using PersonGenerator.Builder.NameBuilder;
using PersonGenerator.Builder.NumberBuilder;

namespace PersonGenerator.Builder
{
    public class PersonBuilder: IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder lastNameBuilder;
        private readonly INumberBuilder ageBuilder;

        public PersonBuilder(GeneratorSettings settings)
        {
            if (settings.FirstName)
            {
                firstNameBuilder = new FirstNameBuilder(settings);
            }
            else
            {
                firstNameBuilder = new EmptyNameBuilder();
            }

            if (settings.LastName)
            {
                lastNameBuilder = new LastNameBuilder(settings);
            }
            else
            {
                lastNameBuilder = new EmptyNameBuilder();
            }

            if (settings.Age)
            {
                ageBuilder = new AgeBuilder(settings);
            }
            else
            {
                ageBuilder = new EmptyNumberBuilder();
            }
        }

        public Person Build()
        {
            Person person = new Person
            {
                FirstName = firstNameBuilder.Build(),
                LastName = lastNameBuilder.Build(),
                Age = ageBuilder.Build()
            };

            return person;
        }
    }
}
