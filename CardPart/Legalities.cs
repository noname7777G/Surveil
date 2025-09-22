using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class Legalities {
	[JsonPropertyName("standard")]
	public required string Standard { get; set; }

	[JsonPropertyName("future")]
	public required string Future { get; set; }

	[JsonPropertyName("historic")]
	public required string Historic { get; set; }

	[JsonPropertyName("pioneer")]
	public required string Pioneer { get; set; }

	[JsonPropertyName("modern")]
	public required string Modern { get; set; }

	[JsonPropertyName("legacy")]
	public required string Legacy { get; set; }

	[JsonPropertyName("pauper")]
	public required string Pauper { get; set; }

	[JsonPropertyName("vintage")]
	public required string Vintage { get; set; }

	[JsonPropertyName("penny")]
	public required string Penny { get; set; }

	[JsonPropertyName("commander")]
	public required string Commander { get; set; }

	[JsonPropertyName("brawl")]
	public required string Brawl { get; set; }

	[JsonPropertyName("historic_brawl")]
	public required string HistoricBrawl { get; set; }

	[JsonPropertyName("alchemy")]
	public required string Alchemy { get; set; }

	[JsonPropertyName("pauper_commander")]
	public required string PauperCommander { get; set; }

	[JsonPropertyName("duel")]
	public required string Duel { get; set; }

	[JsonPropertyName("oldschool")]
	public required string Oldschool { get; set; }

	[JsonPropertyName("premodern")]
	public required string Premodern { get; set; }
}
