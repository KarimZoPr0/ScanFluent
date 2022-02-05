namespace ScanFluent.Commands
{
	public class StartCommand : Command
	{
		public override string Id() => "-start";
		public override void Execute(FeatureProcessor? processor)
		{
			processor?.PerformScan();
		}
		

	}
}