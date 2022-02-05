using Rextester;
using static System.Console;
namespace ScanFluent
{
	public static class Validation
	{
		public static bool HasFeature(this FeatureProcessor? processor, IFeature? type) => processor.Features.Contains(type);

		public static bool CanRemove(this FeatureProcessor? processor)
		{
			if (processor.Features.Count > 0) return true;
			WriteLine("There is no feature to remove");
			WriteLine();
			return false;

		}
	}
}