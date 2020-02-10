using System;

namespace PersonGenerator.Builder.DateBuilder
{
    internal interface IDateBuilder
    {
        public DateTime Build();
        public DateTime BuildWithParams(params int[] list);
    }
}
