using Logger.Core;
using Logger.Core.Factories;
using Logger.Core.IO;

IAppenderFactory appenderFactory = new AppenderFactory();
ILayoutFactory layoutFactory = new LayoutFactory();
IReader reader = new ConsoleReader();

IEngine engine = new Engine(appenderFactory, layoutFactory, reader);

engine.Run();