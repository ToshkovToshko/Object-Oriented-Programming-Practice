﻿using Logger.Appenders;
using Logger.Enums;
using Logger.Layouts;

namespace Logger.Core.Factories
{
    interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout, ReportLevel reportLevel);
    }
}
