using System.Linq;
using Rextester;
using ScanFluent.Commands;
using static System.Console;
namespace ScanFluent
{
	public static class Show
	{
		public static void CommandOptions()
		{
			WriteLine("Choose a command");
			WriteLine("-----------------------");

			CommandEvaluator.commands.ForEach(command => WriteLine($"{command.Id()}"));
			WriteLine();
		}

		public static void AllFeatures()
		{
			WriteLine("Add a feature");
			WriteLine("-----------------------");
			
			foreach (var feature in FeatureEvaluator.FeatureQuery)
			{
				Display(feature);
			}
			WriteLine();
		}

		public static void AddedFeatures(FeatureProcessor processor) => processor.ShowCurrentItems();

		public static void ShowCurrentItems(this FeatureProcessor processor)
		{
			WriteLine("Current Features");
			WriteLine("-----------------------");

			if (processor.Features.Any())
			{
				foreach (var feature in processor.Features)
				{
					Display(feature);
				}
				return;
			}

			WriteLine("There is no features to show!");
		}

		private static void Display(IFeature feature) => WriteLine($" [{feature.Id()}] {feature.Description()}");

	}
}