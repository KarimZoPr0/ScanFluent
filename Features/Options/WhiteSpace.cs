using System;
using System.Linq;
using System.Text.RegularExpressions;
using Rextester;

namespace ScanFluent
{
	public class WhiteSpace : IFeature
	{
		public string Id() => "1";
		public string Description() => "Remove multiple whitespaces";
		public string Pattern() => @"[ ]{2,}";

		public string Replacement(Match match) => " ";

	}

}