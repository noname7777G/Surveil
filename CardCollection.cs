using System.Text.Json;
namespace Surveil;

public class CardCollection : List<Card> {
	public enum ListFormat {
		MTGO,
		Moxfield,
		Arena,
	}

	public CardCollection? ParentCollection { get; private set; }
	private bool RulingsAttached;

	public static CardCollection LoadFromJson(string path) {
		string JsonIn = File.ReadAllText(path);
		return JsonSerializer.Deserialize<CardCollection>(JsonIn) ?? throw new Exception("Error deserializing file");
	}

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

	public Card? GetCardByName(string name) {
		foreach(Card card in this) {
			if(card.Name == name)
				return card;
		}
		return null;
	}

	/// <summary>
	/// Returns an empty <see cref="CardCollection"/> that inherits some of the properties of it's <see cref="ParentCollection"/>.
	/// </summary>
	/// <returns></returns>
	public CardCollection CreateSubCollection() {
		CardCollection newCollection = [];
		if(RulingsAttached) { newCollection.RulingsAttached = true; }
		newCollection.ParentCollection = this;

		return newCollection;
	}

	/// <summary>
	/// Returns a <see cref="CardCollection"/> that inherits some of the properties of it's <see cref="ParentCollection"/> and contains only cards legal in the given <paramref name="format"/>.
	/// </summary>
	/// <param name="format"></param>
	/// <returns></returns>
	public CardCollection CreateSubCollection(Format format) {
		if(format == Format.None) { return this; }

		CardCollection newCollection = CreateSubCollection();
		string formatName = format.ToString();
		foreach(Card card in this) {
			if(card.Legalities.TryGetValue(formatName, out Legality legality) && legality == Legality.Legal || legality == Legality.Restricted) {
				newCollection.Add(card);
			}
		}
		return newCollection;
	}
}
