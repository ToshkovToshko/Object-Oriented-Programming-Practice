using Logger.Layouts;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public abstract void Append(string date, string reportLevel, string message);
    }
}
