using Surveil.CardParts;
using System.Text.Json.Serialization;
namespace Surveil;

public enum Legality {
	Legal,
	NotLegal,
	Restricted,
	Banned,
}

public class Card {
	/// <summary>
	/// This card’s Arena ID, if any. A large percentage of cards are not available on Arena and do not have this ID.
	/// </summary>
	[JsonPropertyName("arena_id")]
	public int? ArenaId { get; set; }
	//TODO: Look into switching to GUIDs for all apropriate properties.
	/// <summary>
	/// A unique ID for this card in Scryfall’s database.
	/// </summary>
	[JsonPropertyName("id")]
	public required string Id { get; set; }
	/// <summary>
	/// A language code for this printing.
	/// </summary>
	[JsonPropertyName("lang")]
	public required string Lang { get; set; }
	/// <summary>
	/// This card’s Magic Online ID (also known as the Catalog ID), if any. A large percentage of cards are not available on Magic Online and do not have this ID.
	/// </summary>
	[JsonPropertyName("mtgo_id")]
	public int? MtgoId { get; set; }
	/// <summary>
	/// This card’s foil Magic Online ID (also known as the Catalog ID), if any. A large percentage of cards are not available on Magic Online and do not have this ID.
	/// </summary>
	[JsonPropertyName("mtgo_foil_id")]
	public int? MtgoFoilId { get; set; }
	/// <summary>
	/// This card’s multiverse IDs on Gatherer, if any, as an array of integers. Note that Scryfall includes many promo cards, tokens, and other esoteric objects that do not have these identifiers.
	/// </summary>
	[JsonPropertyName("multiverse_ids")]
	public int[]? MultiverseIds { get; set; }
	/// <summary>
	/// This card’s ID on TCGplayer’s API, also known as the productId.
	/// </summary>
	[JsonPropertyName("tcgplayer_id")]
	public int? TcgplayerId { get; set; }
	/// <summary>
	/// This card’s ID on TCGplayer’s API, for its etched version if that version is a separate product.
	/// </summary>
	[JsonPropertyName("tcgplayer_etched_id")]
	public int? TcgplayerEtchedId { get; set; }
	/// <summary>
	/// This card’s ID on Cardmarket’s API, also known as the idProduct.
	/// </summary>
	[JsonPropertyName("cardmarket_id")]
	public int? CardmarketId { get; set; }
	/// <summary>
	/// A code for this card’s layout.
	/// </summary>
	[JsonPropertyName("layout")]
	public required string Layout { get; set; }
	/// <summary>
	/// A unique ID for this card’s oracle identity. This value is consistent across reprinted card editions, and unique among different cards with the same name (tokens, Unstable variants, etc). Always present except for the reversible_card layout where it will be absent; oracle_id will be found on each face instead.
	/// </summary>
	[JsonPropertyName("oracle_id")]
	public string? OracleId { get; set; }
	/// <summary>
	/// A link to where you can begin paginating all re/prints for this card on Scryfall’s API.
	/// </summary>
	[JsonPropertyName("prints_search_uri")]
	public required Uri PrintsSearchUri { get; set; }
	/// <summary>
	/// A link to this card’s rulings list on Scryfall’s API.
	/// </summary>
	[JsonPropertyName("rulings_uri")]
	public required Uri RulingsUri { get; set; }
	/// <summary>
	/// A link to this card’s permapage on Scryfall’s website.
	/// </summary>
	[JsonPropertyName("scryfall_uri")]
	public required Uri ScryfallUri { get; set; }
	/// <summary>
	/// A link to this card object on Scryfall’s API.
	/// </summary>
	[JsonPropertyName("uri")]
	public required Uri Uri { get; set; }
	/// <summary>
	/// If this card is closely related to other cards, this property will be an array with Related Card Objects.
	/// </summary>
	[JsonPropertyName("all_parts")]
	public RelatedPart[]? AllParts { get; set; }
	/// <summary>
	/// An array of Card Face objects, if this card is multifaced.
	/// </summary>
	[JsonPropertyName("card_faces")]
	public CardFace[]? CardFaces { get; set; }
	/// <summary>
	/// The card’s mana value. Note that some funny cards have fractional mana costs.
	/// </summary>
	[JsonPropertyName("cmc")]
	public Decimal Cmc { get; set; }
	/// <summary>
	/// This card’s color identity.
	/// </summary>
	[JsonPropertyName("color_identity")]
	public required char[] ColorIdentity { get; set; }
	/// <summary>
	/// The colors in this card’s color indicator, if any. A null value for this field indicates the card does not have one.
	/// </summary>
	[JsonPropertyName("color_indicator")]
	public char[]? ColorIndicator { get; set; }
	/// <summary>
	/// This card’s colors, if the overall card has colors defined by the rules. Otherwise the colors will be on the card_faces objects, see below.
	/// </summary>
	[JsonPropertyName("colors")]
	public char[]? Colors { get; set; }
	/// <summary>
	/// This face’s defense, if any.
	/// </summary>
	[JsonPropertyName("defense")]
	public string? Defense { get; set; }
	/// <summary>
	/// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
	/// </summary>
	[JsonPropertyName("edhrec_rank")]
	public int? EdhrecRank { get; set; }
	/// <summary>
	/// True if this card is on the Commander Game Changer list.
	/// </summary>
	[JsonPropertyName("game_changer")]
	public bool? GameChanger { get; set; }
	/// <summary>
	/// This card’s hand modifier, if it is Vanguard card. This value will contain a delta, such as -1.
	/// </summary>
	[JsonPropertyName("hand_modifier")]
	public string? HandModifier { get; set; }
	/// <summary>
	/// An array of keywords that this card uses, such as 'Flying' and 'Cumulative upkeep'.
	/// </summary>
	[JsonPropertyName("keywords")]
	public required string[] Keywords { get; set; }
	/// <summary>
	/// An object describing the legality of this card across play formats. Possible legalities are legal, not_legal, restricted, and banned.
	/// </summary>
	[JsonPropertyName("legalities")]
	[JsonConverter(typeof(ScryfallLegalityConverter))]
	public required Dictionary<string, Legality> Legalities { get; set; }
	/// <summary>
	/// This card’s life modifier, if it is Vanguard card. This value will contain a delta, such as +2.
	/// </summary>
	[JsonPropertyName("life_modifier")]
	public string? LifeModifier { get; set; }
	/// <summary>
	/// This loyalty if any. Note that some cards have loyalties that are not numeric, such as X.
	/// </summary>
	[JsonPropertyName("loyalty")]
	public string? Loyalty { get; set; }
	/// <summary>
	/// The mana cost for this card. This value will be any empty string. If the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. Multi-faced cards will report this value in card faces.
	/// </summary>
	[JsonPropertyName("mana_cost")]
	public string? ManaCost { get; set; }
	/// <summary>
	/// The name of this card. If this card has multiple faces, this field will contain both names separated by _//_.
	/// </summary>
	[JsonPropertyName("name")]
	public required string Name { get; set; }
	/// <summary>
	/// The Oracle text for this card, if any.
	/// </summary>
	[JsonPropertyName("oracle_text")]
	public string? OracleText { get; set; }
	/// <summary>
	/// This card’s rank/popularity on Penny Dreadful. Not all cards are ranked.
	/// </summary>
	[JsonPropertyName("penny_rank")]
	public int? PennyRank { get; set; }
	/// <summary>
	/// This card’s power, if any. Note that some cards have powers that are not numeric, such as *.
	/// </summary>
	[JsonPropertyName("power")]
	public string? Power { get; set; }
	/// <summary>
	/// Colors of mana that this card could produce.
	/// </summary>
	[JsonPropertyName("produced_mana")]
	public char[]? ProducedMana { get; set; }
	/// <summary>
	/// True if this card is on the Reserved List.
	/// </summary>
	[JsonPropertyName("reserved")]
	public bool Reserved { get; set; }
	/// <summary>
	/// This card’s toughness, if any. Note that some cards have toughnesses that are not numeric, such as *.
	/// </summary>
	[JsonPropertyName("toughness")]
	public string? Toughness { get; set; }
	/// <summary>
	/// The type line of this card.
	/// </summary>
	[JsonPropertyName("type_line")]
	public string? TypeLine { get; set; }
	/// <summary>
	/// The name of the illustrator of this card. Newly spoiled cards may not have this field yet.
	/// </summary>
	[JsonPropertyName("artist")]
	public string? Artist { get; set; }
	/// <summary>
	/// The IDs of the artists that illustrated this card. Newly spoiled cards may not have this field yet.
	/// </summary>
	[JsonPropertyName("artist_ids")]
	public string[]? ArtistIds { get; set; }
	/// <summary>
	/// The lit Unfinity attractions lights on this card, if any.
	/// </summary>
	[JsonPropertyName("attraction_lights")]
	public int[]? AttractionLights { get; set; }
	/// <summary>
	/// Whether this card is found in boosters.
	/// </summary>
	[JsonPropertyName("booster")]
	public bool Booster { get; set; }
	/// <summary>
	/// This card’s border color: black, white, borderless, yellow, silver, or gold.
	/// </summary>
	[JsonPropertyName("border_color")]
	public required string BorderColor { get; set; }
	/// <summary>
	/// The Scryfall ID for the card back design present on this card.
	/// </summary>
	[JsonPropertyName("card_back_id")]
	public string? CardBackId { get; set; }
	/// <summary>
	/// This card’s collector number. Note that collector numbers can contain non-numeric characters, such as letters or .
	/// </summary>
	[JsonPropertyName("collector_number")]
	public required string CollectorNumber { get; set; }
	/// <summary>
	/// True if you should consider avoiding use of this print downstream.
	/// </summary>
	[JsonPropertyName("content_warning")]
	public bool? ContentWarning { get; set; }
	/// <summary>
	/// True if this card was only released in a video game.
	/// </summary>
	[JsonPropertyName("digital")]
	public bool Digital { get; set; }
	/// <summary>
	/// An array of computer-readable flags that indicate if this card can come in foil, nonfoil, or etched finishes.
	/// </summary>
	[JsonPropertyName("finishes")]
	public required string[] Finishes { get; set; }
	/// <summary>
	/// The just-for-fun name printed on the card (such as for Godzilla series cards).
	/// </summary>
	[JsonPropertyName("flavor_name")]
	public string? FlavorName { get; set; }
	/// <summary>
	/// The flavor text, if any.
	/// </summary>
	[JsonPropertyName("flavor_text")]
	public string? FlavorText { get; set; }
	/// <summary>
	/// This card’s frame effects, if any.
	/// </summary>
	[JsonPropertyName("frame_effects")]
	public string[]? FrameEffects { get; set; }
	/// <summary>
	/// This card’s frame layout.
	/// </summary>
	[JsonPropertyName("frame")]
	public required string Frame { get; set; }
	/// <summary>
	/// True if this card’s artwork is larger than normal.
	/// </summary>
	[JsonPropertyName("full_art")]
	public bool FullArt { get; set; }
	/// <summary>
	/// A list of games that this card print is available in, paper, arena, and/or mtgo.
	/// </summary>
	[JsonPropertyName("games")]
	public required string[] Games { get; set; }
	/// <summary>
	/// True if this card’s imagery is high resolution.
	/// </summary>
	[JsonPropertyName("highres_image")]
	public bool HighresImage { get; set; }
	/// <summary>
	/// A unique identifier for the card artwork that remains consistent across reprints. Newly spoiled cards may not have this field yet.
	/// </summary>
	[JsonPropertyName("illustration_id")]
	public string? IllustrationId { get; set; }
	/// <summary>
	/// A computer-readable indicator for the state of this card’s image, one of missing, placeholder, lowres, or highres_scan.
	/// </summary>
	[JsonPropertyName("image_status")]
	public required string ImageStatus { get; set; }
	/// <summary>
	/// An object listing available imagery for this card. See the Card Imagery article for more information.
	/// </summary>
	[JsonPropertyName("image_uris")]
	public ImageUris? ImageUris { get; set; }
	/// <summary>
	/// True if this card is oversized.
	/// </summary>
	[JsonPropertyName("oversized")]
	public bool Oversized { get; set; }
	/// <summary>
	/// An object containing daily price information for this card, including usd, usd_foil, usd_etched, eur, eur_foil, eur_etched, and tix prices, as strings.
	/// </summary>
	[JsonPropertyName("prices")]
	public required Prices Prices { get; set; }
	/// <summary>
	/// The localized name printed on this card, if any.
	/// </summary>
	[JsonPropertyName("printed_name")]
	public string? PrintedName { get; set; }
	/// <summary>
	/// The localized text printed on this card, if any.
	/// </summary>
	[JsonPropertyName("printed_text")]
	public string? PrintedText { get; set; }
	/// <summary>
	/// The localized type line printed on this card, if any.
	/// </summary>
	[JsonPropertyName("printed_type_line")]
	public string? PrintedTypeLine { get; set; }
	/// <summary>
	/// True if this card is a promotional print.
	/// </summary>
	[JsonPropertyName("promo")]
	public bool Promo { get; set; }
	/// <summary>
	/// An array of strings describing what categories of promo cards this card falls into.
	/// </summary>
	[JsonPropertyName("promo_types")]
	public string[]? PromoTypes { get; set; }
	/// <summary>
	/// An object providing Uris to this card’s listing on major marketplaces. Omitted if the card is unpurchaseable.
	/// </summary>
	[JsonPropertyName("purchase_uris")]
	public PurchaseUris? PurchaseUris { get; set; }
	/// <summary>
	/// This card’s rarity. One of common, uncommon, rare, special, mythic, or bonus.
	/// </summary>
	[JsonPropertyName("rarity")]
	public required string Rarity { get; set; }
	/// <summary>
	/// An object providing Uris to this card’s listing on other Magic: The Gathering online resources.
	/// </summary>
	[JsonPropertyName("related_uris")]
	public required RelatedUris RelatedUris { get; set; }
	/// <summary>
	/// The date this card was first released.
	/// </summary>
	[JsonPropertyName("released_at")]
	public DateTime ReleasedAt { get; set; }
	/// <summary>
	/// True if this card is a reprint.
	/// </summary>
	[JsonPropertyName("reprint")]
	public bool Reprint { get; set; }
	/// <summary>
	/// A link to this card’s set on Scryfall’s website.
	/// </summary>
	[JsonPropertyName("scryfall_set_uri")]
	public required Uri ScryfallSetUri { get; set; }
	/// <summary>
	/// This card’s full set name.
	/// </summary>
	[JsonPropertyName("set_name")]
	public required string SetName { get; set; }
	/// <summary>
	/// A link to where you can begin paginating this card’s set on the Scryfall API.
	/// </summary>
	[JsonPropertyName("set_search_uri")]
	public required Uri SetSearchUri { get; set; }
	/// <summary>
	/// The type of set this printing is in.
	/// </summary>
	[JsonPropertyName("set_type")]
	public required string SetType { get; set; }
	/// <summary>
	/// A link to this card’s set object on Scryfall’s API.
	/// </summary>
	[JsonPropertyName("set_uri")]
	public required Uri SetUri { get; set; }
	/// <summary>
	/// This card’s set code.
	/// </summary>
	[JsonPropertyName("set")]
	public required string Set { get; set; }
	/// <summary>
	/// This card’s Set object Guid.
	/// </summary>
	[JsonPropertyName("set_id")]
	public required string SetId { get; set; }
	/// <summary>
	/// True if this card is a Story Spotlight.
	/// </summary>
	[JsonPropertyName("story_spotlight")]
	public bool StorySpotlight { get; set; }
	/// <summary>
	/// True if the card is printed without text.
	/// </summary>
	[JsonPropertyName("textless")]
	public bool Textless { get; set; }
	/// <summary>
	/// Whether this card is a variation of another printing.
	/// </summary>
	[JsonPropertyName("variation")]
	public bool Variation { get; set; }
	/// <summary>
	/// The printing ID of the printing this card is a variation of.
	/// </summary>
	[JsonPropertyName("variation_of")]
	public string? VariationOf { get; set; }
	/// <summary>
	/// The security stamp on this card, if any. One of oval, triangle, acorn, circle, arena, or heart.
	/// </summary>
	[JsonPropertyName("security_stamp")]
	public string? SecurityStamp { get; set; }
	/// <summary>
	/// This card’s watermark, if any.
	/// </summary>
	[JsonPropertyName("watermark")]
	public string? Watermark { get; set; }
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("preview")]
	public Preview? Preview { get; set; }

	internal void AddRuling(Ruling ruling) {
		Rulings ??= [];
		Rulings.Add(ruling);
	}
	public List<Ruling>? Rulings { get; private set; }
}
