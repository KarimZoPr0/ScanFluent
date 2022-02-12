using Rextester;

namespace ScanFluent
{
	public abstract class Component
	{
		public readonly string? Path;
		protected Component(string? path) => (Path) = (path);
		public abstract void Add(IFeature s);
		public abstract void Remove(IFeature s);
	}
}