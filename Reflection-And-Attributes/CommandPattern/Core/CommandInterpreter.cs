using CommandPattern.Commands;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        private readonly ICommandFactory commandFactory;

        public CommandInterpreter()
        {
            this.commandFactory = new CommandFactory();
        }

        public string Read(string args)
        {
            //Read input data
            string[] parts = args.Split();

            string commandType = parts[0];
            string[] commandArgs = parts.Skip(1).ToArray();

            //Command creation
            ICommand command = this.commandFactory.CreateCommand(commandType);

            return command.Execute(commandArgs);
        }
    }
}
