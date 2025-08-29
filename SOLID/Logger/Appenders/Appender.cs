using Logger.Enums;
using Logger.Layouts;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected readonly ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public abstract void Append(string date, ReportLevel reportLevel, string message);
    }
}
