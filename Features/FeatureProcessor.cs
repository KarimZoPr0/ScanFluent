using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Rextester;
using static System.Console;

namespace ScanFluent
{
	public class FeatureProcessor : Component
	{
		private static string path = "input.txt";
		public FeatureProcessor(string name) : base(name) { }
		
		public Action<FeatureProcessor, IFeature>? AddEvent;
		public Action<FeatureProcessor, IFeature>? RemoveEvent;

		public readonly List<IFeature> Features = new();

		public override void Add(IFeature feature)
		{
			Features.Add(feature);
			AddEvent?.Invoke(this, feature);
		}
		
		public override void Remove(IFeature feature)
		{
			Features.Remove(feature);
			RemoveEvent?.Invoke(this, feature);
		}
		
		public void PerformScan()
		{
			if (!Features.Any())
			{
				WriteLine("No features added!");
				return;
			}
				
			string text = File.ReadAllText(path);

			foreach (var feature in Features)
			{
				var regexCasing = new Regex(feature.Pattern(), RegexOptions.Multiline);

				text = regexCasing.Replace(text, feature.Result);
				File.WriteAllText(path, $"{text}");
			}

			WriteLine("Complete!");
		}

		
	}
}