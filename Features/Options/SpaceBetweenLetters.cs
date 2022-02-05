using System.Text.RegularExpressions;
using Rextester;

namespace ScanFluent
{
	public class SpaceBetweenLetters : IFeature
	{
		public string Id() => "1";
		public string Description() => "Ta bort duplicerade mellanrum";
		public string Pattern() => @"\s+";
		public string Result(Match match) => " ";
	}

}