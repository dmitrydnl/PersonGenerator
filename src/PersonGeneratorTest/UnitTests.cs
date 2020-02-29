using System;
using System.Collections.Generic;
using NUnit.Framework;
using PersonGenerator;

namespace PersonGeneratorTest
{
    public class GenerateTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void NameTest()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                Language = Languages.English,
                FirstName = true,
                MiddleName = true,
                LastName = true
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool nameCorrect = true;
            foreach (Person person in people)
            {
                nameCorrect = !string.IsNullOrEmpty(person.FirstName) &&
                    !string.IsNullOrEmpty(person.MiddleName) &&
                    !string.IsNullOrEmpty(person.LastName);

                if (!nameCorrect)
                {
                    break;
                }
            }

            Assert.AreEqual(nameCorrect, true);
        }

        [Test]
        public void AgeTest()
        {
            Random random = new Random();
            int minAge = random.Next(0, 50);
            int maxAge = random.Next(50, 101);

            GeneratorSettings settings = new GeneratorSettings
            {
                Age = true,
                MinAge = minAge,
                MaxAge = maxAge
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool ageCorrect = true;
            foreach (Person person in people)
            {
                ageCorrect = person.Age.Value >= minAge && person.Age.Value <= maxAge;
                if (!ageCorrect)
                {
                    break;
                }
            }

            Assert.AreEqual(ageCorrect, true);
        }

        [Test]
        public void EmailTest()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                Email = true
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool emailCorrect = true;
            foreach (Person person in people)
            {
                emailCorrect = !string.IsNullOrEmpty(person.Email);
                if (!emailCorrect)
                {
                    break;
                }
            }

            Assert.AreEqual(emailCorrect, true);
        }

        [Test]
        public void PhoneNumberTest()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                PhoneNumber = true
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool phoneNumberCorrect = true;
            foreach (Person person in people)
            {
                phoneNumberCorrect = !string.IsNullOrEmpty(person.PhoneNumber);
                if (!phoneNumberCorrect)
                {
                    break;
                }
            }

            Assert.AreEqual(phoneNumberCorrect, true);
        }

        [Test]
        public void GenderTest()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                Sex = true
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool genderCorrect = true;
            foreach (Person person in people)
            {
                genderCorrect = person.Sex != null;
                if (!genderCorrect)
                {
                    break;
                }
            }

            Assert.AreEqual(genderCorrect, true);
        }

        [Test]
        public void CountryTest()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                Language = Languages.English,
                Country = true
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(100);
            bool countryCorrect = true;
            foreach (Person person in people)
            {
                countryCorrect = !string.IsNullOrEmpty(person.Country);

                if (!countryCorrect)
                {
                    break;
                }
                person.Print();
            }

            Assert.AreEqual(countryCorrect, true);
        }
    }
}
