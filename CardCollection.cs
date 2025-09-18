using System.Text.Json;
namespace Surveil;

public class CardCollection : List<Card> {

	static CardCollection AllCards = [];
	public static void LoadAllCards(string bulkDataPath) {
		string JsonIn = File.ReadAllText(bulkDataPath);
		AllCards = (CardCollection?)JsonSerializer.Deserialize<List<Card>>(JsonIn) ?? throw new Exception("Error deserializing bulk data");
	}

	public static CardCollection LoadCards(string path) {
		string JsonIn = File.ReadAllText(path);
		return (CardCollection?)JsonSerializer.Deserialize<List<Card>>(JsonIn) ?? throw new Exception("Error deserializing file");
	}
}
