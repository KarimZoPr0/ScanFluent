using System.Collections.Generic;
using System.Linq;
using Rextester;

namespace ScanFluent
{
	public static class FeatureEvaluator
	{
		public static readonly List<IFeature> Features = new()
		{
			new CapitalLetter(),
			new WhiteSpace()
		};

		public static readonly IEnumerable<IFeature> FeatureQuery = Features.OrderBy(feature => feature.Id());
	}
}