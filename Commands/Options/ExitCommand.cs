using static System.Environment;

namespace ScanFluent.Commands
{
	public class ExitCommand : Command
	{
		public override string Id() => "-exit";
		public override void Execute(FeatureProcessor? processor) => Exit(0);
		
	}
}