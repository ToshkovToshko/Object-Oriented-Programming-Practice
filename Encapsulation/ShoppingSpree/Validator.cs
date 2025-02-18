using System.ComponentModel.Design;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfStringIsNullOrEmpty(string str, string exMessage)
        {
            if(string.IsNullOrWhiteSpace(str)) 
            {
                throw new ArgumentException(exMessage);
            }
        }

        public static void ThrowIfMoneyIsNegative(decimal value, string exMessage)
        {
            if (value < 0)
            {
                throw new ArgumentException(exMessage);

            }
        }
    }
}
