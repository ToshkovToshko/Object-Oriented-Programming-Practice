using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Telephony
{
    class Smartphone : Phone, IBrowsable
    {
        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }

            return $"Browsing: {url}";
        }

        public override string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
            
            return $"Calling... {number}";
        }
    }
}
