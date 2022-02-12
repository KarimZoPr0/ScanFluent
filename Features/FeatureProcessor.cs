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
		public FeatureProcessor(string? path) : base(path) { }
		
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
			
			if (File.Exists(Path))
			{
				WriteLine("File Doesn't exist");
				return;
			}
			
			string text = File.ReadAllText(Path);
			

			foreach (var feature in Features)
			{
				var regexCasing = new Regex(feature.Pattern(), RegexOptions.Multiline);

				text = regexCasing.Replace(text, feature.Replacement);
				File.WriteAllText(Path, $"{text}");
			}

			WriteLine("Complete!");
		}

		
	}
}