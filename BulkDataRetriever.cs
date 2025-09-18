using System;
using System.Linq.Expressions;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Surveil;

public static class BulkDataRetriever {

	public enum BulkDataType {
		default_cards,
		oracle_cards,
		unique_artwork,
		all_cards,
	}

	private static readonly HttpClient client = new();
	public static string UserAgent {
		get {
			if(client.DefaultRequestHeaders.TryGetValues("User-Agent", out IEnumerable<string>? keys)) {
				return keys.First();
			} else {
				return "";
			}
		}
		set {
			if(value == null || value == ""){
				throw new DataRetrievalException("User-Agent cannot be empty or null");
			}
			client.DefaultRequestHeaders.Remove("User-Agent");
			client.DefaultRequestHeaders.Add("User-Agent", value);
		}
	}
	
	private static string _bulkDataPath = "";
	public static string BulkDataPath {
		get {
			return _bulkDataPath;	
		}
		set {
			if(value == null || value == "") {
				throw new DataRetrievalException("No path provided");
			} 
			else if(!Path.Exists(value)) {
				throw new DataRetrievalException("Invalid path provided");
			}
			_bulkDataPath = value;
		}
	}
	
	static BulkDataRetriever() {
		client.DefaultRequestHeaders.Add("Accept", "application/json");
	}	
	

	public static async Task FetchCards(BulkDataType bulkDataType = BulkDataType.default_cards) {

		string appendStr = bulkDataType.ToString();

		HttpResponseMessage message = await client.GetAsync(@$"https://api.scryfall.com/bulk-data/{appendStr}");
		message.EnsureSuccessStatusCode();
		JsonElement json = await message.Content.ReadFromJsonAsync<JsonElement>();
		string newUri = json.GetProperty("download_uri").ToString();

		HttpResponseMessage bulkDataMsg = await client.GetAsync(newUri);
		bulkDataMsg.EnsureSuccessStatusCode();
		Stream downloadStream = await bulkDataMsg.Content.ReadAsStreamAsync();

		FileStream fileStream = File.Create(@$"{_bulkDataPath}\{appendStr}.txt");
		downloadStream.Seek(0, SeekOrigin.Begin);
		downloadStream.CopyTo(fileStream);
		fileStream.Close();
	}

	public static async Task FetchRulings() {
		HttpResponseMessage message = await client.GetAsync(@$"https://api.scryfall.com/bulk-data/rulings");
		message.EnsureSuccessStatusCode();
		JsonElement json = await message.Content.ReadFromJsonAsync<JsonElement>();
		string newUri = json.GetProperty("download_uri").ToString();

		HttpResponseMessage bulkDataMsg = await client.GetAsync(newUri);
		bulkDataMsg.EnsureSuccessStatusCode();
		Stream downloadStream = await bulkDataMsg.Content.ReadAsStreamAsync();

		FileStream fileStream = File.Create(@$"{_bulkDataPath}\rulings.txt");
		downloadStream.Seek(0, SeekOrigin.Begin);
		downloadStream.CopyTo(fileStream);
		fileStream.Close();
	}
}

public class DataRetrievalException : Exception {
	public DataRetrievalException() {
	}

	public DataRetrievalException(string? message) : base(message) {
	}

	public DataRetrievalException(string? message, Exception? innerException) : base(message, innerException) {
	}

}

