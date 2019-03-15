using System;
using System.Runtime.Serialization;

namespace DoomRPG
{
	[DataContract]
	internal class Branch
	{
		public Branch(string Name, Commit Commit, bool Protected)
		{
			this.name = Name;
			this.commit = Commit;
			this.protect = Protected;
		}

		[DataMember]
		public string name;

		[DataMember]
		public Commit commit;

		[DataMember]
		public bool protect;
	}
}
