using System;
using System.Runtime.Serialization;

namespace DoomRPG
{
	[DataContract]
	internal class Commit
	{
		public Commit(string SHA, string URL)
		{
			this.sha = SHA;
			this.url = URL;
		}

		[DataMember]
		public string sha;

		[DataMember]
		public string url;
	}
}
