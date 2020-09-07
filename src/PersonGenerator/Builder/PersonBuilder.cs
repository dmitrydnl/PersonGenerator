using System;
using PersonGenerator.Builder.NameBuilder;
using PersonGenerator.Builder.GenderBuilder;
using PersonGenerator.Builder.NumberBuilder;
using PersonGenerator.Builder.DateBuilder;
using PersonGenerator.Builder.CountryBuilder;
using PersonGenerator.Builder.EmailBuilder;
using PersonGenerator.Builder.PhoneNumberBuilder;

namespace PersonGenerator.Builder
{
    internal class PersonBuilder : IPersonBuilder
    {
        private readonly INameBuilder firstNameBuilder;
        private readonly INameBuilder middleNameBuilder;
        private readonly INameBuilder lastNameBuilder;
        private readonly IGenderBuilder genderBuilder;
        private readonly INumberBuilder ageBuilder;
        private readonly IDateBuilder birthDateBuilder;
        private readonly ICountryBuilder countryBuilder;
        private readonly IEmailBuilder emailBuilder;
        private readonly IPhoneNumberBuilder phoneNumberBuilder;

        internal PersonBuilder(GeneratorSettings settings)
        {
            firstNameBuilder = GetFirstNameBuilder(settings);
            middleNameBuilder = GetMiddleNameBuilder(settings);
            lastNameBuilder = GetLastNameBuilder(settings);
            genderBuilder = GetGenderBuilder(settings);
            ageBuilder = GetAgeBuilder(settings);
            birthDateBuilder = GetBirthDateBuilder(settings);
            countryBuilder = GetCountryBuilder(settings);
            emailBuilder = GetEmailBuilder(settings);
            phoneNumberBuilder = GetPhoneNumberBuilder(settings);
        }

        public Person Build()
        {
            string firstName = firstNameBuilder.Build();
            string middleName = middleNameBuilder.Build();
            string lastName = lastNameBuilder.Build();
            Gender? sex = genderBuilder.Build();
            int? age = ageBuilder.Build();
            DateTime? birthDate = age == null ? birthDateBuilder.Build() : birthDateBuilder.BuildWithParams(age.Value);
            string country = countryBuilder.Build();
            string email = emailBuilder.BuildWithParams(firstName, lastName, age.ToString());
            string phoneNumber = phoneNumberBuilder.Build();

            return new Person
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                Sex = sex,
                Age = age,
                BirthDate = birthDate,
                Country = country,
                Email = email,
                PhoneNumber = phoneNumber
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

        private IGenderBuilder GetGenderBuilder(GeneratorSettings settings)
        {
            if (settings.Sex)
            {
                return new SexBuilder();
            }

            return new EmptyGenderBuilder();
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

        private ICountryBuilder GetCountryBuilder(GeneratorSettings settings)
        {
            if (settings.Country)
            {
                return new HomeCountryBuilder(settings);
            }

            return new EmptyCountryBuilder();
        }

        private IEmailBuilder GetEmailBuilder(GeneratorSettings settings)
        {
            if (settings.Email)
            {
                return new HomeEmailBuilder();
            }

            return new EmptyEmailBuilder();
        }

        private IPhoneNumberBuilder GetPhoneNumberBuilder(GeneratorSettings settings)
        {
            if (settings.PhoneNumber)
            {
                return new MobilePhoneNumberBuilder();
            }

            return new EmptyPhoneNumberBuilder();
        }
    }
}
