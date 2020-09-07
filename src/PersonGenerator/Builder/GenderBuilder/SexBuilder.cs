using PersonGenerator.Random;

namespace PersonGenerator.Builder.GenderBuilder
{
    internal class SexBuilder : IGenderBuilder
    {
        public Gender? Build()
        {
            int sex = NumberRandom.GetRandomNumber(0, 1);
            return sex == 0 ? Gender.Male : Gender.Female;
        }
    }
}
