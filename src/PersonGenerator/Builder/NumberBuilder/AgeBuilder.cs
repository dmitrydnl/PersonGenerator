using PersonGenerator.Random;

namespace PersonGenerator.Builder.NumberBuilder
{
    public class AgeBuilder: INumberBuilder
    {
        private readonly GeneratorSettings settings;

        public AgeBuilder(GeneratorSettings settings)
        {
            this.settings = settings;
        }

        public int Build()
        {
            return NumberRandom.GetRandomNumber(settings.MinAge, settings.MaxAge);
        }
    }
}
