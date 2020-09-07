using System;

namespace PersonGenerator.Builder.DateBuilder
{
    internal class EmptyDateBuilder : IDateBuilder
    {
        public DateTime? Build()
        {
            return null;
        }

        public DateTime? BuildWithParams(params int[] list)
        {
            return null;
        }
    }
}
