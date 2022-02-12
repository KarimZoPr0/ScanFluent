using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

namespace ScanFluent.Commands
{
	public abstract class Command
	{
		protected IEnumerable<string> UserComamnd(string text)
		{
			Write(text);
			var userInput = ReadLine();

			return userInput?.Split(",")!;
		}

		public abstract string Id();
		public abstract void Execute(FeatureProcessor processor);
	}
}