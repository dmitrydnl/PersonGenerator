using PersonGenerator.Random;

namespace PersonGenerator.Builder.NumberBuilder
{
    internal class AgeBuilder : INumberBuilder
    {
        private readonly GeneratorSettings settings;

        internal AgeBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
        }

        public int Build()
        {
            return NumberRandom.GetRandomNumber(settings.MinAge, settings.MaxAge);
        }
    }
}
