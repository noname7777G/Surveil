using System.Text.Json.Serialization;

namespace Surveil.CardPart;

public class Legalities {
	public Legalities(string standard, string future, string historic, string pioneer, string modern, string legacy, string pauper, string vintage, string penny, string commander, string brawl, string historicBrawl, string alchemy, string pauperCommander, string duel, string oldschool, string premodern) {
		Standard = standard;
		Future = future;
		Historic = historic;
		Pioneer = pioneer;
		Modern = modern;
		Legacy = legacy;
		Pauper = pauper;
		Vintage = vintage;
		Penny = penny;
		Commander = commander;
		Brawl = brawl;
		HistoricBrawl = historicBrawl;
		Alchemy = alchemy;
		PauperCommander = pauperCommander;
		Duel = duel;
		Oldschool = oldschool;
		Premodern = premodern;
	}

	[JsonPropertyName("standard")]
	public string Standard { get; set; }

	[JsonPropertyName("future")]
	public string Future { get; set; }

	[JsonPropertyName("historic")]
	public string Historic { get; set; }

	[JsonPropertyName("pioneer")]
	public string Pioneer { get; set; }

	[JsonPropertyName("modern")]
	public string Modern { get; set; }

	[JsonPropertyName("legacy")]
	public string Legacy { get; set; }

	[JsonPropertyName("pauper")]
	public string Pauper { get; set; }

	[JsonPropertyName("vintage")]
	public string Vintage { get; set; }

	[JsonPropertyName("penny")]
	public string Penny { get; set; }

	[JsonPropertyName("commander")]
	public string Commander { get; set; }

	[JsonPropertyName("brawl")]
	public string Brawl { get; set; }

	[JsonPropertyName("historic_brawl")]
	public string HistoricBrawl { get; set; }

	[JsonPropertyName("alchemy")]
	public string Alchemy { get; set; }

	[JsonPropertyName("pauper_commander")]
	public string PauperCommander { get; set; }

	[JsonPropertyName("duel")]
	public string Duel { get; set; }

	[JsonPropertyName("oldschool")]
	public string Oldschool { get; set; }

	[JsonPropertyName("premodern")]
	public string Premodern { get; set; }
}
