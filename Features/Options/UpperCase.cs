using System.Text.RegularExpressions;
using Rextester;

namespace ScanFluent
{
	public class UpperCase : IFeature
	{
		public string Id() => "2";

		public string Description() => "Stor bokstav efter punkt";

		public string Pattern() => @"[\.\?\!]\s+([a-z])";

		public string Result(Match match) => match.Value.ToUpper();
		
	}
}