using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;

namespace Logger.Appenders
{
    class FileAppender : Appender
    {
        private readonly ILogFile logfile;

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.logfile = logfile;
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            string content = string.Format(this.layout.Template, date, reportLevel, message) + Environment.NewLine;

            this.logfile.Write(content);
        }
    }
}
