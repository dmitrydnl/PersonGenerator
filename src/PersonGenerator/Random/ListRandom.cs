using System.Collections.Generic;

namespace PersonGenerator.Random
{
    internal static class ListRandom
    {
        private readonly static System.Random random = new System.Random();

        internal static T GetRandomElement<T>(List<T> list)
        {
            int i = random.Next(list.Count);
            return list[i];
        }
    }
}
