using System;
using System.Linq.Expressions;

namespace ScryfallObjects;

public static class BulkDataRetriever {
	public static async Task UpdateBulkData(string bulkDataType = "default-cards") {
		HttpClient client = new();
		client.DefaultRequestHeaders.Add("User-Agent", "ScryfallObjects_CSharp_lib");
		client.DefaultRequestHeaders.Add("Accept", "application/json");
		HttpResponseMessage message = await client.GetAsync(@$"https://api.scryfall.com/bulk-data/{bulkDataType}");
		message.EnsureSuccessStatusCode();
		Console.Write(message.Content);
	}
}
