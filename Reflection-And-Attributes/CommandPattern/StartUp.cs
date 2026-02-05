using CommandPattern.Commands;
using CommandPattern.Core;
using CommandPattern.Core.Contracts;


ICommandInterpreter command = new CommandInterpreter();
IEngine engine = new Engine(command);
engine.Run();
