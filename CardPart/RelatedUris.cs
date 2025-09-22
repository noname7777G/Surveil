using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class RelatedUris {
	[JsonPropertyName("gatherer")]
	public required string Gatherer { get; set; }

	[JsonPropertyName("tcgplayer_decks")]
	public required string TcgplayerDecks { get; set; }

	[JsonPropertyName("edhrec")]
	public required string Edhrec { get; set; }

	[JsonPropertyName("mtgtop8")]
	public required string Mtgtop8 { get; set; }
}
