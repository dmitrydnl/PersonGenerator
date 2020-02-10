using System;

namespace PersonGenerator.Builder.DateBuilder
{
    internal class EmptyDateBuilder : IDateBuilder
    {
        public DateTime Build()
        {
            return DateTime.Now;
        }

        public DateTime BuildWithParams(params int[] list)
        {
            return DateTime.Now;
        }
    }
}
