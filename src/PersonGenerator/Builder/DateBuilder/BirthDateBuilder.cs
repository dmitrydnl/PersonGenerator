using System;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.DateBuilder
{
    internal class BirthDateBuilder : IDateBuilder
    {
        public DateTime? Build()
        {
            return DateRandom.GetRandomDayAndMonth();
        }

        public DateTime? BuildWithParams(params int[] list)
        {
            int age = list.Length >= 1 ? list[0] : 0;
            DateTime birthDate = Build().Value;
            DateTime now = DateTime.Now;
            if (now.Month > birthDate.Month || (now.Month == birthDate.Month && now.Day >= birthDate.Day))
            {
                birthDate = birthDate.AddYears(now.Year - birthDate.Year - age);
            }
            else
            {
                birthDate = birthDate.AddYears(now.Year - birthDate.Year - age - 1);
            }

            return birthDate;
        }
    }
}
