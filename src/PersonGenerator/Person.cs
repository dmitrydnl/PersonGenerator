using System;
using System.Text;

namespace PersonGenerator
{
    public class Person
    {
        public string FirstName { get; internal set; }
        public string MiddleName { get; internal set; }
        public string LastName { get; internal set; }
        public int Age { get; internal set; }
        public DateTime BirthDate { get; internal set; }
        public string Email { get; internal set; }

        internal Person()
        {

        }

        public void Print()
        {
            PrintName();
            PrintAge();
            PrintEmail();
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

        private void PrintEmail()
        {
            if (!string.IsNullOrEmpty(Email))
            {
                Console.WriteLine("Email: " + Email);
            }
        }
    }
}
