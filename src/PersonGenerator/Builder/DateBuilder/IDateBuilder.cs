using System;

namespace PersonGenerator.Builder.DateBuilder
{
    public interface IDateBuilder
    {
        public DateTime Build();
        public DateTime BuildWithParams(params int[] list);
    }
}
