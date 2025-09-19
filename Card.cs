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

	public int ScryfallId { get; set; }
	public string Lang { get; set; }
	public string Layout { get; set; }
	public Uri PrintsSearchUri { get; set; }
	public Uri RulingsUri { get; set; }
	public Uri ScryfallUri { get; set; }
	public Uri Uri { get; set; }
	public Decimal Cmc { get; set; }
	public CColors ColorIdentity { get; set; }
	public Array Keywords { get; set; }
	public Legalities Legalities { get; set; }
	public string Name { get; set; }
	public bool Reserved { get; set; }
	public string TypeLine { get; set; }
	public bool Booster { get; set; }
	public string BorderColor { get; set; }
	public Guid CardBackId { get; set; }
	public string CollectorNumber { get; set; }
	public bool Digital { get; set; }
	public Array finishes { get; set; }
	public string frame { get; set; }
	public bool full_art { get; set; }
	public Array games { get; set; }
	public bool highres_image { get; set; }
	public string image_status { get; set; }
	public bool oversized { get; set; }
	public Prices prices { get; set; }
	public bool promo { get; set; }
	public string rarity { get; set; }
	public RelatedUris related_uris { get; set; }
	public DateTime released_at { get; set; }
	public bool reprint { get; set; }
	public Uri scryfall_set_uri { get; set; }
	public string set_name { get; set; }
	public Uri set_search_uri { get; set; }
	public string set_type { get; set; }
	public Uri set_uri { get; set; }
	public string set { get; set; }
	public Guid set_id { get; set; }
	public bool story_spotlight { get; set; }
	public bool textless { get; set; }
	public bool variation { get; set; }
}
