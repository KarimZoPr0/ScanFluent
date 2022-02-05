using System;
using System.Linq;
using Rextester;
using static System.Console;
namespace ScanFluent.Commands
{
	public class RemoveCommand : Command
	{
		public override string Id() => "-remove";

		public override void Execute(FeatureProcessor processor)
		{
			if (!processor.CanRemove()) return;

			Show.AddedFeatures(processor);


			var commands = UserComamnd("Which feature do you want to remove: ");

			foreach (var command in commands)
			{
				var scanType = FeatureEvaluator.features.Single(x => x.Id() == command);
				if (!processor.HasFeature(scanType))
				{
					WriteLine($"Feature {scanType.Id()} is not added yet!");
					return;
				}

				processor.Remove(scanType);
			}
		}
	}
}