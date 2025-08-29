using Logger.Appenders;
using Logger.Enums;
using System.Text;

namespace Logger.Loggers
{
    class Loggerr : ILogger
    {
        private readonly IAppender[] appenders;

        public Loggerr(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Critical(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Critical, message);
        }

        public void Warning(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Warning, message);
        }

        public void Error(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Error, message);
        }

        public void Fatal(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Fatal, message);
        }

        public void Info(string date, string message)
        {
            this.AppendToAppenders(date, ReportLevel.Info, message);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString();
        }

        private void AppendToAppenders(string date, ReportLevel reportLevel, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }
    }
}
