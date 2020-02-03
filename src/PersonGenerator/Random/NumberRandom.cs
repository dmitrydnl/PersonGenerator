namespace PersonGenerator.Random
{
    internal static class NumberRandom
    {
        private readonly static System.Random random = new System.Random();

        internal static int GetRandomNumber(int min, int max)
        {
            max = max != int.MaxValue ? max + 1 : max;
            return random.Next(min, max);
        }
    }
}
