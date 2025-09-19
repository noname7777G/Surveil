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
	public required string Lang { get; set; }
	public required string Layout { get; set; }
	public required Uri PrintsSearchUri { get; set; }
	public required Uri RulingsUri { get; set; }
	public required Uri ScryfallUri { get; set; }
	public required Uri Uri { get; set; }
	public Decimal Cmc { get; set; }
	public required CColors ColorIdentity { get; set; }
	public required Array Keywords { get; set; }
	public Legalities Legalities { get; set; }
	public required string Name { get; set; }
	public bool Reserved { get; set; }
	public required string TypeLine { get; set; }
	public bool Booster { get; set; }
	public required string BorderColor { get; set; }
	public Guid CardBackId { get; set; }
	public required string CollectorNumber { get; set; }
	public bool Digital { get; set; }
	public required Array Finishes { get; set; }
	public required string Frame { get; set; }
	public bool FullArt { get; set; }
	public required Array Games { get; set; }
	public bool HighresImage { get; set; }
	public required string ImageStatus { get; set; }
	public bool Oversized { get; set; }
	public Prices Prices { get; set; }
	public bool Promo { get; set; }
	public required string Rarity { get; set; }
	public RelatedUris RelatedUris { get; set; }
	public DateTime ReleasedAt { get; set; }
	public bool Reprint { get; set; }
	public required Uri ScryfallSetUri { get; set; }
	public required string SetName { get; set; }
	public required Uri SetSearchUri { get; set; }
	public required string SetType { get; set; }
	public required Uri SetUri { get; set; }
	public required string Set { get; set; }
	public Guid SetId { get; set; }
	public bool StorySpotlight { get; set; }
	public bool Textless { get; set; }
	public bool Variation { get; set; }
}
