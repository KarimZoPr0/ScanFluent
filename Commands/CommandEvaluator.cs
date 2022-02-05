using System.Collections.Generic;

namespace ScanFluent.Commands
{
	public static class CommandEvaluator
	{
		public static List<Command> commands = new()
		{
			new AddCommand(),
			new RemoveCommand(),
			new ShowCommand(),
			new ExitCommand(),
			new StartCommand()
		};
		public static IEnumerable<Command> CommandFactories() => commands;
	}
}