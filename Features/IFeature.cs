using System;
using System.Text.RegularExpressions;

namespace Rextester
{
	public interface IFeature
	{
		public string Id();
		public string Description();
		public string Pattern();

		public string Replacement(Match match);

	}
}