using System.Text.Json.Serialization;

namespace Surveil.CardParts;

public class PurchaseUris {
	[JsonPropertyName("tcgplayer")]
	public required string Tcgplayer { get; set; }

	[JsonPropertyName("cardmarket")]
	public required string Cardmarket { get; set; }

	[JsonPropertyName("ebay")]
	public string? Ebay { get; set; }
}
