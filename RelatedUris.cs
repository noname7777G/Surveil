using System.Text.Json.Serialization;

namespace ScryfallObjects;

public class RelatedUris {
	public RelatedUris(string gatherer, string tcgplayerDecks, string edhrec, string mtgtop8) {
		Gatherer = gatherer;
		TcgplayerDecks = tcgplayerDecks;
		Edhrec = edhrec;
		Mtgtop8 = mtgtop8;
	}

	[JsonPropertyName("gatherer")]
	public string Gatherer { get; set; }

	[JsonPropertyName("tcgplayer_decks")]
	public string TcgplayerDecks { get; set; }

	[JsonPropertyName("edhrec")]
	public string Edhrec { get; set; }

	[JsonPropertyName("mtgtop8")]
	public string Mtgtop8 { get; set; }
}
