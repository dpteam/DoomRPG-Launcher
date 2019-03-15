using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace DoomRPG
{
	internal static class Octokitten
	{
		public static async Task<Branch[]> GetAllBranches(string author, string repository)
		{
			HttpClient httpClient = new HttpClient();
			httpClient.BaseAddress = new Uri("https://api.github.com");
			httpClient.DefaultRequestHeaders.Add("User-Agent", "DRPGSEL");
			DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(Branch[]));
			DataContractJsonSerializer dataContractJsonSerializer2 = dataContractJsonSerializer;
			Stream stream = await httpClient.GetStreamAsync(string.Concat(new string[]
			{
				"repos/",
				author,
				"/",
				repository,
				"/branches"
			}));
			return (Branch[])dataContractJsonSerializer2.ReadObject(stream);
		}
	}
}
