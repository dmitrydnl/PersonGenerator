﻿using PersonGenerator.Random;

namespace PersonGenerator.Builder.EmailBuilder
{
    internal class HomeEmailBuilder : IEmailBuilder
    {
        public string Build()
        {
            string randomStr = StringRandom.GetRandomAlphanumericString(8);
            return randomStr + "@gmail.com";
        }

        public string BuildWithParams(params string[] list)
        {
            string firstName = list.Length >= 1 ? list[0] : null;
            string lastName = list.Length >= 2 ? list[1] : null;
            string age = list.Length >= 3 ? list[2] : null;

            if (!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName))
            {
                return firstName + lastName + age + "@gmail.com";
            }

            return Build();
        }
    }
}
