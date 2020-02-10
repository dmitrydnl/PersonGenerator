using System;
using PersonGenerator.Builder.NameBuilder;
using PersonGenerator.Builder.NumberBuilder;
using PersonGenerator.Builder.DateBuilder;
using PersonGenerator.Builder.EmailBuilder;

namespace PersonGenerator.Builder
{
    internal class PersonBuilder : IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder middleNameBuilder;
        private readonly INameBuilder lastNameBuilder;
        private readonly INumberBuilder ageBuilder;
        private readonly IDateBuilder birthDateBuilder;
        private readonly IEmailBuilder emailBuilder;

        internal PersonBuilder(GeneratorSettings settings)
        {
            firstNameBuilder = GetFirstNameBuilder(settings);
            middleNameBuilder = GetMiddleNameBuilder(settings);
            lastNameBuilder = GetLastNameBuilder(settings);
            ageBuilder = GetAgeBuilder(settings);
            birthDateBuilder = GetBirthDateBuilder(settings);
            emailBuilder = GetEmailBuilder(settings);
        }

        public Person Build()
        {
            string firstName = firstNameBuilder.Build();
            string middleName = middleNameBuilder.Build();
            string lastName = lastNameBuilder.Build();
            int age = ageBuilder.Build();
            DateTime birthDate = birthDateBuilder.BuildWithParams(age);
            string email = emailBuilder.BuildWithParams(firstName, lastName, age.ToString());

            return new Person
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Age = age,
                BirthDate = birthDate,
                Email = email
            };
        }

        private INameBuilder GetFirstNameBuilder(GeneratorSettings settings)
        {
            if (settings.FirstName)
            {
                return new FirstNameBuilder(settings);
            }

            return new EmptyNameBuilder();
        }

        private INameBuilder GetMiddleNameBuilder(GeneratorSettings settings)
        {
            if (settings.MiddleName)
            {
                return new MiddleNameBuilder(settings);
            }

            return new EmptyNameBuilder();
        }

        private INameBuilder GetLastNameBuilder(GeneratorSettings settings)
        {
            if (settings.LastName)
            {
                return new LastNameBuilder(settings);
            }

            return new EmptyNameBuilder();
        }

        private INumberBuilder GetAgeBuilder(GeneratorSettings settings)
        {
            if (settings.Age)
            {
                return new AgeBuilder(settings);
            }

            return new EmptyNumberBuilder();
        }

        private IDateBuilder GetBirthDateBuilder(GeneratorSettings settings)
        {
            if (settings.Age)
            {
                return new BirthDateBuilder();
            }

            return new EmptyDateBuilder();
        }

        private IEmailBuilder GetEmailBuilder(GeneratorSettings settings)
        {
            if (settings.Email)
            {
                return new HomeEmailBuilder();
            }

            return new EmptyEmailBuilder();
        }
    }
}
