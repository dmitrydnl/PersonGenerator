using System;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.DateBuilder
{
    public class BirthDateBuilder: IDateBuilder
    {
        public DateTime Build()
        {
            return DateRandom.GetRandomDayAndMonth();
        }
    }
}
