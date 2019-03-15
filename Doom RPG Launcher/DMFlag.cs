using System;

namespace DoomRPG
{
	internal struct DMFlag
	{
		public int Key { get; }

		public string Name { get; }

		public bool DefaultState { get; }

		public string Description { get; }

		public DMFlag(int key, string name, bool state, string desc)
		{
			this.Key = key;
			this.Name = name;
			this.DefaultState = state;
			this.Description = desc;
		}
	}
}
