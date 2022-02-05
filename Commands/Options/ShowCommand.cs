namespace ScanFluent.Commands
{
	public class ShowCommand : Command
	{
		public override string Id() => "-show";

		public override void Execute(FeatureProcessor? processor) => processor?.ShowCurrentItems();
		
	}
}