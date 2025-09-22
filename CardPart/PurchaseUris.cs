using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class PurchaseUris {
	[JsonPropertyName("tcgplayer")]
	public required string Tcgplayer { get; set; }

	[JsonPropertyName("cardmarket")]
	public required string Cardmarket { get; set; }

	[JsonPropertyName("ebay")]
	public required string Ebay { get; set; }
}
