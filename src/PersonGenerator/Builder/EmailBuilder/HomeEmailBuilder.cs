using PersonGenerator.Random;

namespace PersonGenerator.Builder.EmailBuilder
{
    public class HomeEmailBuilder: IEmailBuilder
    {
        public string Build()
        {
            string randomStr = StringRandom.GetRandomAlphanumericString(8);
            return randomStr + "@gmail.com";
        }
    }
}
