using System.Text.Json.Serialization;

namespace Surveil.CardParts;

public class CardFace {
	/// <summary>
	/// The name of the illustrator of this card face. Newly spoiled cards may not have this field yet. 
	/// </summary>
	[JsonPropertyName("artist")]
	public string? Artist { get; set; }
	/// <summary>
	/// The ID of the illustrator of this card face. Newly spoiled cards may not have this field yet. 
	/// </summary>
	[JsonPropertyName("artist_id")]
	public string? ArtistId { get; set; }
	/// <summary>
	/// The mana value of this particular face, if the card is reversible. 
	/// </summary>
	[JsonPropertyName("cmc")]
	public Decimal? Cmc { get; set; }
	/// <summary>
	/// The colors in this face’s color indicator, if any. 
	/// </summary>
	[JsonPropertyName("color_indicator")]
	public char[]? ColorIndicator { get; set; }
	/// <summary>
	/// This face’s colors, if the game defines colors for the individual face of this card. 
	/// </summary>
	[JsonPropertyName("colors")]
	public char[]? Colors { get; set; }
	/// <summary>
	/// This face’s defense, if any. 
	/// </summary>
	[JsonPropertyName("defense")]
	public string? Defense { get; set; }
	/// <summary>
	/// The flavor text printed on this face, if any. 
	/// </summary>
	[JsonPropertyName("flavor_text")]
	public string? Flavor_text { get; set; }
	/// <summary>
	/// A unique identifier for the card face artwork that remains consistent across reprints. Newly spoiled cards may not have this field yet. 
	/// </summary>
	[JsonPropertyName("illustration_id")]
	public string? IllustrationId { get; set; }
	/// <summary>
	/// An object providing URIs to imagery for this face, if this is a double-sided card. If this card is not double-sided, then the image_uris property will be part of the parent object instead. 
	/// </summary>
	[JsonPropertyName("image_uris")]
	public ImageUris? ImageUris { get; set; }
	/// <summary>
	/// The layout of this card face, if the card is reversible. 
	/// </summary>
	[JsonPropertyName("layout")]
	public string? Layout { get; set; }
	/// <summary>
	/// This face’s loyalty, if any. 
	/// </summary>
	[JsonPropertyName("loyalty")]
	public string? Loyalty { get; set; }
	/// <summary>
	/// The mana cost for this face. This value will be any empty string 
	/// <para>if  the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. </para>
	/// </summary>
	[JsonPropertyName("mana_cost")]
	public required string ManaCost { get; set; }
	/// <summary>
	/// The name of this particular face. 
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }
	/// <summary>
	/// The Oracle ID of this particular face, if the card is reversible. 
	/// </summary>
	[JsonPropertyName("oracle_id")]
	public string? OracleId { get; set; }
	/// <summary>
	/// The Oracle text for this face, if any. 
	/// </summary>
	[JsonPropertyName("oracle_text")]
	public string? OracleText { get; set; }
	/// <summary>
	/// This face’s power, if any. Note that some cards have powers that are not numeric, such as *. 
	/// </summary>
	[JsonPropertyName("power")]
	public string? Power { get; set; }
	/// <summary>
	/// The localized name printed on this face, if any. 
	/// </summary>
	[JsonPropertyName("printed_name")]
	public string? PrintedName { get; set; }
	/// <summary>
	/// The localized text printed on this face, if any. 
	/// </summary>
	[JsonPropertyName("printed_text")]
	public string? PrintedText { get; set; }
	/// <summary>
	/// The localized type line printed on this face, if any. 
	/// </summary>
	[JsonPropertyName("printed_type_line")]
	public string? PrintedTypeLine { get; set; }
	/// <summary>
	/// This face’s toughness, if any. 
	/// </summary>
	[JsonPropertyName("toughness")]
	public string? Toughness { get; set; }
	/// <summary>
	/// The type line of this particular face, if the card is reversible. 
	/// </summary>
	[JsonPropertyName("type_line")]
	public string? TypeLine { get; set; }
	/// <summary>
	/// The watermark on this particulary card face, if any. 
	/// </summary>
	[JsonPropertyName("watermark")]
	public string? Watermark { get; set; }
}
