﻿using System;
using System.Text;

namespace PersonGenerator
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public void Print()
        {
            PrintName();
            PrintAge();
        }

        private void PrintName()
        {
            StringBuilder name = new StringBuilder();
            name.Append(!string.IsNullOrEmpty(FirstName) ? FirstName + " " : "");
            name.Append(!string.IsNullOrEmpty(MiddleName) ? MiddleName + " " : "");
            name.Append(!string.IsNullOrEmpty(LastName) ? LastName + " " : "");
            Console.WriteLine(name.ToString().Trim());
        }

        private void PrintAge()
        {
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Birth date: " + BirthDate.ToShortDateString());
        }
    }
}
