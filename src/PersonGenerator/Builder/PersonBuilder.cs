using System;
using PersonGenerator.Builder.NameBuilder;
using PersonGenerator.Builder.NumberBuilder;
using PersonGenerator.Builder.DateBuilder;
using PersonGenerator.Builder.EmailBuilder;

namespace PersonGenerator.Builder
{
    public class PersonBuilder: IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder middleNameBuilder;
        private readonly INameBuilder lastNameBuilder;
        private readonly INumberBuilder ageBuilder;
        private readonly IDateBuilder birthDateBuilder;
        private readonly IEmailBuilder emailBuilder;

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

            if (settings.MiddleName)
            {
                middleNameBuilder = new MiddleNameBuilder(settings);
            }
            else
            {
                middleNameBuilder = new EmptyNameBuilder();
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

            if (settings.Email)
            {
                emailBuilder = new HomeEmailBuilder();
            }
            else
            {
                emailBuilder = new EmptyEmailBuilder();
            }
        }

        public Person Build()
        {
            string firstName = firstNameBuilder.Build();
            string middleName = middleNameBuilder.Build();
            string lastName = lastNameBuilder.Build();
            int age = ageBuilder.Build();
            DateTime birthDate = BirthDateUpdateYear(birthDateBuilder.Build(), age);
            string email = emailBuilder.Build();
            Person person = new Person
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Age = age,
                BirthDate = birthDate,
                Email = email
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
