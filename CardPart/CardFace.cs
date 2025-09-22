using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class CardFace {
	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("printed_name")]
	public required string PrintedName { get; set; }

	[JsonPropertyName("mana_cost")]
	public required string ManaCost { get; set; }

	[JsonPropertyName("cmc")]
	public double Cmc { get; set; }

	[JsonPropertyName("colors")]
	public required List<string> Colors { get; set; }

	[JsonPropertyName("color_indicator")]
	public required List<string> ColorIndicator { get; set; }

	[JsonPropertyName("type_line")]
	public required string TypeLine { get; set; }

	[JsonPropertyName("printed_type_line")]
	public required string PrintedTypeLine { get; set; }

	[JsonPropertyName("oracle_text")]
	public required string OracleText { get; set; }

	[JsonPropertyName("printed_text")]
	public required string PrintedText { get; set; }

	[JsonPropertyName("flavor_text")]
	public required string FlavorText { get; set; }

	[JsonPropertyName("artist")]
	public required string Artist { get; set; }

	[JsonPropertyName("artist_id")]
	public int? ArtistId { get; set; }

	[JsonPropertyName("illustration_id")]
	public int? IllustrationId { get; set; }

	[JsonPropertyName("image_uris")]
	public required ImageUris ImageUris { get; set; }
}
