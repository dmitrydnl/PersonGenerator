using System.Text;
using PersonGenerator.Random;

namespace PersonGenerator.Builder.PhoneNumberBuilder
{
    internal class MobilePhoneNumberBuilder : IPhoneNumberBuilder
    {
        public string Build()
        {
            StringBuilder number = new StringBuilder();
            number.Append("+1 ");
            number.Append(NumberRandom.GetRandomNumber(2, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append("-");
            number.Append(NumberRandom.GetRandomNumber(2, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append("-");
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));
            number.Append(NumberRandom.GetRandomNumber(0, 9));

            return number.ToString();
        }
    }
}
