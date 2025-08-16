namespace Logger.Appenders
{
    public interface IAppender
    {
        void Append(string date, string reportLevel, string message);
    }
}
