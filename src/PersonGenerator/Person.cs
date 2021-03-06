﻿using System;
using System.Text;

namespace PersonGenerator
{
    public class Person
    {
        public string FirstName { get; internal set; }
        public string MiddleName { get; internal set; }
        public string LastName { get; internal set; }
        public Gender? Sex { get; internal set; }
        public int? Age { get; internal set; }
        public DateTime? BirthDate { get; internal set; }
        public string Country { get; internal set; }
        public string Email { get; internal set; }
        public string PhoneNumber { get; internal set; }

        internal Person()
        {
            
        }

        public void Print()
        {
            PrintName();
            PrintSex();
            PrintAge();
            PrintCountry();
            PrintEmail();
            PrintPhoneNumber();
        }

        private void PrintSex()
        {
            if (Sex != null)
            {
                switch (Sex.Value)
                {
                    case Gender.Male:
                        Console.WriteLine("Male");
                        break;
                    case Gender.Female:
                        Console.WriteLine("Female");
                        break;
                }
            }
        }

        private void PrintName()
        {
            StringBuilder name = new StringBuilder();
            name.Append(!string.IsNullOrEmpty(FirstName) ? FirstName + " " : "");
            name.Append(!string.IsNullOrEmpty(MiddleName) ? MiddleName + " " : "");
            name.Append(!string.IsNullOrEmpty(LastName) ? LastName + " " : "");

            if (!string.IsNullOrEmpty(name.ToString().Trim()))
            {
                Console.WriteLine(name.ToString().Trim());
            }
        }

        private void PrintAge()
        {
            if (Age != null)
            {
                Console.WriteLine("Age: " + Age);
            }

            if (BirthDate != null)
            {
                Console.WriteLine("Birth date: " + BirthDate.Value.ToShortDateString());
            }
        }

        private void PrintCountry()
        {
            if (!string.IsNullOrEmpty(Country))
            {
                Console.WriteLine("Country: " + Country);
            }
        }

        private void PrintEmail()
        {
            if (!string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Email: " + Email);
            }
        }

        private void PrintPhoneNumber()
        {
            if (!string.IsNullOrEmpty(PhoneNumber))
            {
                Console.WriteLine("Phone number: " + PhoneNumber);
            }
        }
    }
}
