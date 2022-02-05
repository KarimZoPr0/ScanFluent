using System;
using System.Linq;
using ScanFluent.Commands;
using static System.Console;
namespace ScanFluent
{
	public static class CommandHandler
	{
		public static void SetCommand(this FeatureProcessor processor)
		{
			string? userInput = null;
			while (userInput != "-exit")
			{
				try
				{
					Show.CommandOptions();
					
					Write("Command: ");
					userInput = ReadLine()?.ToLower();
					
					processor.GetCommand(userInput);
				}
				catch (Exception e) { WriteLine(e.Message); }
			}
		}
		private static void GetCommand(this FeatureProcessor processor, string? userCommand)
		{
			var selectedCommand = CommandEvaluator.CommandFactories().Single(x => x.Id() == userCommand);
			selectedCommand.Execute(processor);

		}
	}
}