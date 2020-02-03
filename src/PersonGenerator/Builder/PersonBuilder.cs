using PersonGenerator.Builder.NameBuilder;

namespace PersonGenerator.Builder
{
    public class PersonBuilder: IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder lastNameBuilder;

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
        }

        public Person Build()
        {
            Person person = new Person
            {
                FirstName = firstNameBuilder.Build(),
                LastName = lastNameBuilder.Build()
            };

            return person;
        }
    }
}
