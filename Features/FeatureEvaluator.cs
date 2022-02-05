using System.Collections.Generic;
using System.Linq;
using Rextester;
using ScanFluent.Commands;

namespace ScanFluent
{
	public static class FeatureEvaluator
	{
		public static List<IFeature> features = new()
		{
			new CapitalLetter(),
			new WhiteSpace()
		};

		public static IEnumerable<IFeature> FeatureQuery = features.OrderBy(feature => feature.Id());
		public static IEnumerable<IFeature> FeatureFactories() => features;
	}
}