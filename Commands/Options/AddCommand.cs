using System.Linq;
using Rextester;
using static System.Console;

namespace ScanFluent.Commands
{
	public class AddCommand : Command
	{
		public override string Id() => "-add";

		public override void Execute(FeatureProcessor processor)
		{
			Show.AllFeatures();

			var commands = UserComamnd("Which feature do you want to add: ");
			
			foreach (var command in commands)
			{
				var scanType = FeatureEvaluator.features.Single(x => x.Id() == command);
				if (processor.HasFeature(scanType))
				{
					WriteLine($"Feature {scanType.Id()} Is already added!");
					return;
				}

				processor.Add(scanType);
			}
		}
		
	}
}