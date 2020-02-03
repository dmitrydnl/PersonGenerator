using System;

namespace PersonGenerator.Random
{
    internal static class DateRandom
    {
        internal static DateTime GetRandomDayAndMonth()
        {
            DateTime date = new DateTime();
            int days = NumberRandom.GetRandomNumber(0, 364);
            date = date.AddDays(days);
            return date;
        }
    }
}
