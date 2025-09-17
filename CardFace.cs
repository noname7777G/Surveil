using System.Text.Json.Serialization;

namespace ScryfallObjects;

public class CardFace : BaseObject{
	public CardFace(string objectType, string name, string printedName, string manaCost, double cmc, List<string> colors, List<string> colorIndicator, string typeLine, string printedTypeLine, string oracleText, string printedText, string flavorText, string artist, Guid? artistId, Guid? illustrationId, ImageUris imageUris) : base(objectType){
		Name = name;
		PrintedName = printedName;
		ManaCost = manaCost;
		Cmc = cmc;
		Colors = colors;
		ColorIndicator = colorIndicator;
		TypeLine = typeLine;
		PrintedTypeLine = printedTypeLine;
		OracleText = oracleText;
		PrintedText = printedText;
		FlavorText = flavorText;
		Artist = artist;
		ArtistId = artistId;
		IllustrationId = illustrationId;
		ImageUris = imageUris;
	}

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("printed_name")]
	public string PrintedName { get; set; }

	[JsonPropertyName("mana_cost")]
	public string ManaCost { get; set; }

	[JsonPropertyName("cmc")]
	public double Cmc { get; set; }

	[JsonPropertyName("colors")]
	public List<string> Colors { get; set; }

	[JsonPropertyName("color_indicator")]
	public List<string> ColorIndicator { get; set; }

	[JsonPropertyName("type_line")]
	public string TypeLine { get; set; }

	[JsonPropertyName("printed_type_line")]
	public string PrintedTypeLine { get; set; }

	[JsonPropertyName("oracle_text")]
	public string OracleText { get; set; }

	[JsonPropertyName("printed_text")]
	public string PrintedText { get; set; }

	[JsonPropertyName("flavor_text")]
	public string FlavorText { get; set; }

	[JsonPropertyName("artist")]
	public string Artist { get; set; }

	[JsonPropertyName("artist_id")]
	public Guid? ArtistId { get; set; }

	[JsonPropertyName("illustration_id")]
	public Guid? IllustrationId { get; set; }

	[JsonPropertyName("image_uris")]
	public ImageUris ImageUris { get; set; }
}
