using System.Linq;
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
            string[] tokens = args.Split();
            string commandType = tokens[0];
            string[] commandArgs = tokens.Skip(1).ToArray();

            ICommand command = commandFactory.CreateCommand(commandType);

            return command.Execute(commandArgs);
        }
    }
}
