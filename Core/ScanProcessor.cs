using System;
using System.IO;
using System.Text.RegularExpressions;
using Rextester;
using static System.Console;
namespace ScanFluent
{
	public static class ScanProcessor
	{
		private static FeatureProcessor GetFeatureProcessor()
		{
			string? path = null;

			while (!File.Exists(path + ".txt"))
			{
				Write("Text: "); 
				path = Convert.ToString(ReadLine());
			}

			var processor = new FeatureProcessor(path);
			processor.ApplyEvents();

			WriteLine();
			return processor;
		}

		public static void Run()
		{
			var processor = GetFeatureProcessor();
			processor.SetCommand();
		}
		
		#region Events

		private static void ApplyEvents(this FeatureProcessor processor)
		{
			processor.AddEvent += OnFeatureAdd;
			processor.RemoveEvent += OnFeatureRemove;
		}

		private static void OnFeatureAdd(FeatureProcessor processor, IFeature feature) => WriteLine($"-Added feature {feature.Id()} to {processor.Path}");

		private static void OnFeatureRemove(FeatureProcessor processor, IFeature feature) => WriteLine($"-Removed feature {feature.Id()} from {processor.Path}");

		#endregion
	}
}