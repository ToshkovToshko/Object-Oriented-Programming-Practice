namespace Telephony
{
    abstract class Phone : ICallable
    {
        public abstract string Call(string number);
    }
}
