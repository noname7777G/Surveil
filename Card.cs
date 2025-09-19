using Surveil.CardPart;
using System.Text.Json.Serialization;

namespace Surveil;

public interface ICardProperty {

}

public class CBool : ICardProperty { public bool Value { get; set; } }
public class CInt : ICardProperty { public int Value { get; set; } }
public class CString : ICardProperty { public required string Value { get; set; } }
public class CColors : ICardProperty {
	public required int Count { get; set; }
	public required char[] Values { get; set; }
}
public class CUri : ICardProperty { public required Uri Value { get; set; } }
public class CObject : ICardProperty { public required Dictionary<string, ICardProperty> Value { get; set; } }
public class CDate : ICardProperty { public required DateOnly Value { get; set; } }
public class CArray : ICardProperty { }

public class Card : Dictionary<string, ICardProperty> {

	[JsonPropertyName("id")]
	public int ScryfallId { get; set; }
	[JsonPropertyName("lang")]
	public required string Lang { get; set; }
	[JsonPropertyName("layout")]
	public required string Layout { get; set; }
	[JsonPropertyName("prints_search_uri")]
	public required Uri PrintsSearchUri { get; set; }
	[JsonPropertyName("rulings_uri")]
	public required Uri RulingsUri { get; set; }
	[JsonPropertyName("scryfall_uri")]
	public required Uri ScryfallUri { get; set; }
	[JsonPropertyName("uri")]
	public required Uri Uri { get; set; }
	[JsonPropertyName("cmc")]
	public Decimal Cmc { get; set; }
	[JsonPropertyName("color_identity")]
	public required CColors ColorIdentity { get; set; }
	[JsonPropertyName("keywords")]
	public required Array Keywords { get; set; }
	[JsonPropertyName("legalities")]
	public required Legalities Legalities { get; set; }
	[JsonPropertyName("name")]
	public required string Name { get; set; }
	[JsonPropertyName("reserved")]
	public bool Reserved { get; set; }
	[JsonPropertyName("type_line")]
	public required string TypeLine { get; set; }
	[JsonPropertyName("booster")]
	public bool Booster { get; set; }
	[JsonPropertyName("border_color")]
	public required string BorderColor { get; set; }
	[JsonPropertyName("card_back_id")]
	public Guid CardBackId { get; set; }
	[JsonPropertyName("collector_number")]
	public required string CollectorNumber { get; set; }
	[JsonPropertyName("digital")]
	public bool Digital { get; set; }
	[JsonPropertyName("finishes")]
	public required Array Finishes { get; set; }
	[JsonPropertyName("frame")]
	public required string Frame { get; set; }
	[JsonPropertyName("full_art")]
	public bool FullArt { get; set; }
	[JsonPropertyName("games")]
	public required Array Games { get; set; }
	[JsonPropertyName("highres_image")]
	public bool HighresImage { get; set; }
	[JsonPropertyName("image_status")]
	public required string ImageStatus { get; set; }
	[JsonPropertyName("oversized")]
	public bool Oversized { get; set; }
	[JsonPropertyName("prices")]
	public required Prices Prices { get; set; }
	[JsonPropertyName("promo")]
	public bool Promo { get; set; }
	[JsonPropertyName("rarity")]
	public required string Rarity { get; set; }
	[JsonPropertyName("related_uris")]
	public required RelatedUris RelatedUris { get; set; }
	[JsonPropertyName("released_at")]
	public DateTime ReleasedAt { get; set; }
	[JsonPropertyName("reprint")]
	public bool Reprint { get; set; }
	[JsonPropertyName("scryfall_set_uri")]
	public required Uri ScryfallSetUri { get; set; }
	[JsonPropertyName("set_name")]
	public required string SetName { get; set; }
	[JsonPropertyName("set_search_uri")]
	public required Uri SetSearchUri { get; set; }
	[JsonPropertyName("set_type")]
	public required string SetType { get; set; }
	[JsonPropertyName("set_uri")]
	public required Uri SetUri { get; set; }
	[JsonPropertyName("set")]
	public required string Set { get; set; }
	[JsonPropertyName("set_id")]
	public Guid SetId { get; set; }
	[JsonPropertyName("story_spotlight")]
	public bool StorySpotlight { get; set; }
	[JsonPropertyName("textless")]
	public bool Textless { get; set; }
	[JsonPropertyName("variation")]
	public bool Variation { get; set; }
}
