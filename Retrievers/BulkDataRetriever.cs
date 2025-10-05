using System.Net.Http.Json;
using System.Text.Json;

namespace Surveil.Retrievers;
public enum BulkDataType {
	default_cards,
	oracle_cards,
	unique_artwork,
	all_cards,
}

public static class BulkDataRetriever {
	private static string _bulkDataPath = "";
	public static string BulkDataPath {
		get {
			return _bulkDataPath;
		}
		set {
			if(value == null || value == "") {
				throw new DataRetrievalException("No path provided");
			} else if(!Path.Exists(value)) {
				throw new DataRetrievalException("Invalid path provided");
			}
			_bulkDataPath = value;
		}
	}

	public static async Task FetchCards(BulkDataType bulkDataType = BulkDataType.default_cards) {
		//if(bulkDataType == BulkDataType.all_cards) { bulkDataType = BulkDataType.default_cards; } //Temp fix.

		string appendStr = bulkDataType.ToString();


		HttpResponseMessage message = await WebClient.GetBuffered(@$"https://api.scryfall.com/bulk-data/{appendStr}");
		JsonElement json = await message.Content.ReadFromJsonAsync<JsonElement>();
		string newUri = json.GetProperty("download_uri").ToString();
		//TODO: Figure out how to buffer this so it can actually download all_cards (>2GB).
		HttpResponseMessage bulkDataMsg = await WebClient.GetBuffered(newUri);
		Stream downloadStream = await bulkDataMsg.Content.ReadAsStreamAsync();

		FileStream fileStream = File.Create(@$"{_bulkDataPath}\{appendStr}.txt");
		downloadStream.CopyTo(fileStream);
		fileStream.Close();
	}

	public static async Task FetchRulings() {

		HttpResponseMessage message = await WebClient.GetBuffered(@$"https://api.scryfall.com/bulk-data/rulings");
		JsonElement json = await message.Content.ReadFromJsonAsync<JsonElement>();
		string newUri = json.GetProperty("download_uri").ToString();

		HttpResponseMessage bulkDataMsg = await WebClient.GetBuffered(newUri);
		Stream downloadStream = await bulkDataMsg.Content.ReadAsStreamAsync();

		FileStream fileStream = File.Create(@$"{_bulkDataPath}\rulings.txt");
		downloadStream.CopyTo(fileStream);
		fileStream.Close();
	}
}


