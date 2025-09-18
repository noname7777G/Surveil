using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class PurchaseUris {
	public PurchaseUris(string tcgplayer, string cardmarket, string ebay) {
		Tcgplayer = tcgplayer;
		Cardmarket = cardmarket;
		Ebay = ebay;
	}

	[JsonPropertyName("tcgplayer")]
	public string Tcgplayer { get; set; }

	[JsonPropertyName("cardmarket")]
	public string Cardmarket { get; set; }

	[JsonPropertyName("ebay")]
	public string Ebay { get; set; }
}
