using System.Text.Json.Serialization;

namespace ScryfallObjects;

public class Prices {
	public Prices(decimal? usd, decimal? usdFoil, decimal? usdEtched, decimal? eur, decimal? tix) {
		Usd = usd;
		UsdFoil = usdFoil;
		UsdEtched = usdEtched;
		Eur = eur;
		Tix = tix;
	}

	[JsonPropertyName("usd")]
	[JsonConverter(typeof(ScryfallPriceConverter))]
	public decimal? Usd { get; set; }

	[JsonPropertyName("usd_foil")]
	[JsonConverter(typeof(ScryfallPriceConverter))]
	public decimal? UsdFoil { get; set; }

	[JsonPropertyName("usd_etched")]
	[JsonConverter(typeof(ScryfallPriceConverter))]
	public decimal? UsdEtched { get; set; }

	[JsonPropertyName("eur")]
	[JsonConverter(typeof(ScryfallPriceConverter))]
	public decimal? Eur { get; set; }

	[JsonPropertyName("tix")]
	[JsonConverter(typeof(ScryfallPriceConverter))]
	public decimal? Tix { get; set; }
}
