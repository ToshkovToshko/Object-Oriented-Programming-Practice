using Logger.Appenders;
using Logger.Layouts;
using Logger.Loggers;

var layout = new XmlLayout();
var consoleAppender = new ConsoleAppender(layout);

var file = new LogFile();
var fileAppender = new FileAppender(layout, file);

var logger = new Loggerr(consoleAppender, fileAppender);

logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");