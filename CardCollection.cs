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
		return JsonSerializer.Deserialize<CardCollection?>(JsonIn) ?? throw new Exception("Error deserializing file");
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
		CardCollection collection = [];
		if(RulingsAttached) { collection.RulingsAttached = true; }
		collection.ParentCollection = this;

		return collection;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="cardList"></param>
	/// <param name="listFormat"></param>
	/// <returns></returns>
	public CardCollection CreateSubCollection(string[] cardList, ListFormat listFormat) {
		CardCollection collection = CreateSubCollection();
		switch(listFormat) {
			case ListFormat.MTGO:
				FromMTGOList(ref collection, cardList);
				break;
			case ListFormat.Moxfield:
				break;
			case ListFormat.Arena:
				break;
		}
		return collection;
	}

	private void FromMTGOList(ref CardCollection collection, string[] cardList) {
		foreach(string line in cardList) {
			string[] cardName = line.Split(' ', 2);
			if(GetCardByName(cardName[1]) is Card card) {
				if(int.Parse(cardName[0]) is int quantity and > 1) {
					IEnumerable<Card> cards = [.. Enumerable.Repeat(card, quantity)];
					collection.AddRange(cards);
				} else {
					collection.Add(card);
				}
				continue;
			}
		}
	}

	private void FromArenaList(ref CardCollection collection, string[] cardList) {

	}

	/// <summary>
	/// Returns a <see cref="CardCollection"/> with all cards it was able to find from the file at the given path.
	/// <para><paramref name="listFormat"/> Defaults to <see cref="ListFormat.MTGO"/>.</para>
	///	<para>TODO: Make this infer <see cref="ListFormat"/> from context.</para> 
	/// </summary>
	/// <param name="path"></param>
	/// <param name="listFormat"></param>
	/// <returns></returns>
	public CardCollection CreateSubCollection(string path, ListFormat? listFormat) {
		ListFormat lf;
		//TODO: Make this infer ListFormat from context.
		if(listFormat is null) {
			lf = ListFormat.MTGO;
		} else {
			lf = (ListFormat)listFormat;
		}

		CardCollection collection;
		if(Path.Exists(path)) {
			string[] cardList = File.ReadAllLines(path);
			collection = CreateSubCollection(cardList, lf);
		} else {
			collection = CreateSubCollection();
		}
		return collection;
	}
}
