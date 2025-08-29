using Logger.Appenders;
using Logger.Core.Factories;
using Logger.Core.IO;
using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;

namespace Logger.Core
{
    class Engine : IEngine
    {
        private readonly IAppenderFactory appenderFactory;
        private readonly ILayoutFactory layoutFactory;
        private readonly IReader reader;

        private ILogger logger;

        public Engine(IAppenderFactory appenderFactory, ILayoutFactory layoutFactory, IReader reader)
        {
            this.appenderFactory = appenderFactory;
            this.layoutFactory = layoutFactory;
            this.reader = reader;
        }

        public void Run()
        {
            int n = int.Parse(this.reader.ReadLine());

            IAppender[] appenders = this.ReadAppenders(n);

            this.logger = new Loggerr(appenders);

            while (true)
            {
                string line = this.reader.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);

                ReportLevel reportLevel = Enum.Parse<ReportLevel>(parts[0], true);
                string date = parts[1];
                string message = parts[2];

                this.ProcessCommand(reportLevel, date, message);
            }

            Console.WriteLine(logger);

        }

        private void ProcessCommand(ReportLevel reportLevel, string date, string message)
        {
            switch (reportLevel)
            {
                case ReportLevel.Info:
                    this.logger.Info(date, message);
                    break;

                case ReportLevel.Error:
                    this.logger.Error(date, message);
                    break;

                case ReportLevel.Warning:
                    this.logger.Warning(date, message);
                    break;

                case ReportLevel.Critical:
                    this.logger.Critical(date, message);
                    break;

                case ReportLevel.Fatal:
                    this.logger.Fatal(date, message);
                    break;
            }
        }

        private IAppender[] ReadAppenders(int n)
        {
            IAppender[] appenders = new IAppender[n];

            for (int i = 0; i < n; i++)
            {
                string[] appenderParts = this.reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string appenderType = appenderParts[0];
                string layoutType = appenderParts[1];
                ReportLevel reportLevel = appenderParts.Length == 3
                    ? Enum.Parse<ReportLevel>(appenderParts[2], true)
                    : ReportLevel.Info;

                ILayout layout = layoutFactory.CreateLayout(layoutType);

                IAppender appender = appenderFactory.CreateAppender(appenderType, layout, reportLevel);

                appenders[i] = appender;
            }

            return appenders;
        }
    }
}
