using System.Text.Json;
namespace Surveil;

public class CardCollection : List<Card> {
	public static CardCollection LoadFromJson(string path) {
		string JsonIn = File.ReadAllText(path);
		return JsonSerializer.Deserialize<CardCollection?>(JsonIn) ?? throw new Exception("Error deserializing file");
	}

	private bool RulingsAttached;
	public void AttachRulings(List<Ruling> rulings) {
		if(RulingsAttached) { return; }

		foreach(Ruling ruling in rulings) {
			foreach(Card card in this) {
				if(card.OracleId == ruling.OracleId) {
					card.AddRuling(ruling);
				}
			}
		}
		RulingsAttached = true;
	}


}
