using System.Text.Json;
namespace Surveil;

public class CardCollection : List<Card> {
	public static CardCollection LoadCardsJson(string path) {
		string JsonIn = File.ReadAllText(path);
		return JsonSerializer.Deserialize<CardCollection?>(JsonIn) ?? throw new Exception("Error deserializing file");
	}
}
