using System;
using PersonGenerator.Builder.NameBuilder;
using PersonGenerator.Builder.NumberBuilder;
using PersonGenerator.Builder.DateBuilder;

namespace PersonGenerator.Builder
{
    public class PersonBuilder: IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder lastNameBuilder;
        private readonly INumberBuilder ageBuilder;
        private readonly IDateBuilder birthDateBuilder;

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
                birthDateBuilder = new BirthDateBuilder();
            }
            else
            {
                ageBuilder = new EmptyNumberBuilder();
                birthDateBuilder = new EmptyDateBuilder();
            }
        }

        public Person Build()
        {
            string firstName = firstNameBuilder.Build();
            string lastName = lastNameBuilder.Build();
            int age = ageBuilder.Build();
            DateTime birthDate = BirthDateUpdateYear(birthDateBuilder.Build(), age);
            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                BirthDate = birthDate
            };
            return person;
        }

        private DateTime BirthDateUpdateYear(DateTime birthDate, int age)
        {
            DateTime newBirthDate;
            DateTime now = DateTime.Now;
            if (now.Month > birthDate.Month || (now.Month == birthDate.Month && now.Day >= birthDate.Day))
            {
                newBirthDate = birthDate.AddYears(now.Year - birthDate.Year - age);
            }
            else
            {
                newBirthDate = birthDate.AddYears(now.Year - birthDate.Year - age - 1);
            }

            return newBirthDate;
        }
    }
}
