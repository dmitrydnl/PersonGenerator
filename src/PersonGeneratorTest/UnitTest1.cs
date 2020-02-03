using System;
using System.Collections.Generic;
using NUnit.Framework;
using PersonGenerator;

namespace PersonGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            GeneratorSettings settings = new GeneratorSettings
            {
                Language = Languages.English,
                FirstName = true,
                MiddleName = true,
                LastName = true,
                Age = true,
                MinAge = 20,
                MaxAge = 35
            };

            PersonGenerator.PersonGenerator personGenerator = new PersonGenerator.PersonGenerator(settings);
            List<Person> people = personGenerator.Generate(10);
            foreach (Person person in people)
            {
                person.Print();
                Console.WriteLine();
            }

            Assert.Pass();
        }
    }
}