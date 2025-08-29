namespace Logger.Loggers
{
    interface ILogFile
    {
        int Size { get; }

        void Write(string content);
    }
}
