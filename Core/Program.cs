#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace ScanFluent {
	internal static class Program {
		static void Main(string[] args)
		{
			ScanProcessor.Run();
		}

	}
}