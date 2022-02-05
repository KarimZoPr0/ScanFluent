using System.Text.RegularExpressions;
using Rextester;

namespace ScanFluent
{
	public class CapitalLetter : IFeature
	{
		public string Id() => "2";

		public string Description() => "Capital letter after (.?!)";

		public string Pattern() => @"[\.\?\!]\s+([åäöa-z])";

		public string Replacement(Match match) => match.Value.ToUpper();
		
	}
}