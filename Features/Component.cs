using System;
using Rextester;

namespace ScanFluent
{
	public abstract class Component
	{
		public readonly string Name;
		protected Component(string name) => (Name) = (name);

		public abstract void Add(IFeature s);
		public abstract void Remove(IFeature s);
	}
}