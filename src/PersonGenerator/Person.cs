using System;
using System.Text;

namespace PersonGenerator
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            PrintName();
        }

        private void PrintName()
        {
            StringBuilder name = new StringBuilder();
            name.Append(!string.IsNullOrEmpty(FirstName) ? FirstName + " " : "");
            name.Append(!string.IsNullOrEmpty(LastName) ? LastName + " " : "");
            Console.WriteLine(name.ToString().Trim());
        }
    }
}
