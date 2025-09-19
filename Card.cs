using Surveil.CardPart;
using System.Text.Json.Serialization;
namespace Surveil;

public class Card : BaseObject {

	public Card(string objectType, Guid id, Guid? oracleId, List<int> multiverseIds, int? mtgoId, int? mtgoFoilId, int? arenaId, int? tcgplayerId, int? tcgplayerEtchedId, int? cardmarketId, string name, string printedName, string language, DateTime? releasedAt, string uri, string scryfallUri, string layout, bool highresImage, string imageStatus, ImageUris imageUris, List<CardFace> cardFaces, string manaCost, double cmc, List<string> colors, List<string> colorIdentity, List<string> colorIndicator, string oracleText, string printedText, string typeLine, string printedTypeLine, string power, string toughness, string loyalty, string flavorName, string flavorText, string artist, List<Guid> artistIds, Guid? illustrationId, string borderColor, string frame, List<string> frameEffects, bool fullArt, bool textless, bool booster, bool reserved, bool promo, List<string> promoTypes, bool reprint, string rarity, bool variation, string variationOf, Guid setId, string set, string setName, string setType, string setUri, string setSearchUri, string scryfallSetUri, string rulingsUri, string printsSearchUri, string collectorNumber, bool digital, bool foil, bool nonfoil, List<string> finishes, List<string> games, bool oversized, List<string> producedMana, Legalities legalities, bool storySpotlight, int? edhrecRank, int? pennyRank, Prices prices, RelatedUris relatedUris, PurchaseUris purchaseUris, List<RelatedPart> allParts, string securityStamp) : base(objectType) {
		Id = id;
		OracleId = oracleId;
		MultiverseIds = multiverseIds;
		MtgoId = mtgoId;
		MtgoFoilId = mtgoFoilId;
		ArenaId = arenaId;
		TcgplayerId = tcgplayerId;
		TcgplayerEtchedId = tcgplayerEtchedId;
		CardmarketId = cardmarketId;
		Name = name;
		PrintedName = printedName;
		Language = language;
		ReleasedAt = releasedAt;
		Uri = uri;
		ScryfallUri = scryfallUri;
		Layout = layout;
		HighresImage = highresImage;
		ImageStatus = imageStatus;
		ImageUris = imageUris;
		CardFaces = cardFaces;
		ManaCost = manaCost;
		Cmc = cmc;
		Colors = colors;
		ColorIdentity = colorIdentity;
		ColorIndicator = colorIndicator;
		OracleText = oracleText;
		PrintedText = printedText;
		TypeLine = typeLine;
		PrintedTypeLine = printedTypeLine;
		Power = power;
		Toughness = toughness;
		Loyalty = loyalty;
		FlavorName = flavorName;
		FlavorText = flavorText;
		Artist = artist;
		ArtistIds = artistIds;
		IllustrationId = illustrationId;
		BorderColor = borderColor;
		Frame = frame;
		FrameEffects = frameEffects;
		FullArt = fullArt;
		Textless = textless;
		Booster = booster;
		Reserved = reserved;
		Promo = promo;
		PromoTypes = promoTypes;
		Reprint = reprint;
		Rarity = rarity;
		Variation = variation;
		VariationOf = variationOf;
		SetId = setId;
		Set = set;
		SetName = setName;
		SetType = setType;
		SetUri = setUri;
		SetSearchUri = setSearchUri;
		ScryfallSetUri = scryfallSetUri;
		RulingsUri = rulingsUri;
		PrintsSearchUri = printsSearchUri;
		CollectorNumber = collectorNumber;
		Digital = digital;
		Foil = foil;
		Nonfoil = nonfoil;
		Finishes = finishes;
		Games = games;
		Oversized = oversized;
		ProducedMana = producedMana;
		Legalities = legalities;
		StorySpotlight = storySpotlight;
		EdhrecRank = edhrecRank;
		PennyRank = pennyRank;
		Prices = prices;
		RelatedUris = relatedUris;
		PurchaseUris = purchaseUris;
		AllParts = allParts;
		SecurityStamp = securityStamp;
	}

	[JsonPropertyName("id")]
	public Guid Id { get; set; }

	[JsonPropertyName("oracle_id")]
	public Guid? OracleId { get; set; }

	[JsonPropertyName("multiverse_ids")]
	public List<int> MultiverseIds { get; set; }

	[JsonPropertyName("mtgo_id")]
	public int? MtgoId { get; set; }

	[JsonPropertyName("mtgo_foil_id")]
	public int? MtgoFoilId { get; set; }

	[JsonPropertyName("arena_id")]
	public int? ArenaId { get; set; }

	[JsonPropertyName("tcgplayer_id")]
	public int? TcgplayerId { get; set; }

	[JsonPropertyName("tcgplayer_etched_id")]
	public int? TcgplayerEtchedId { get; set; }

	[JsonPropertyName("cardmarket_id")]
	public int? CardmarketId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("printed_name")]
	public string PrintedName { get; set; }

	[JsonPropertyName("lang")]
	public string Language { get; set; }

	[JsonPropertyName("released_at")]
	[JsonConverter(typeof(ScryfallDateConverter))]
	public DateTime? ReleasedAt { get; set; }

	[JsonPropertyName("uri")]
	public string Uri { get; set; }

	[JsonPropertyName("scryfall_uri")]
	public string ScryfallUri { get; set; }

	[JsonPropertyName("layout")]
	public string Layout { get; set; }

	[JsonPropertyName("highres_image")]
	public bool HighresImage { get; set; }

	[JsonPropertyName("image_status")]
	public string ImageStatus { get; set; }

	[JsonPropertyName("image_uris")]
	public ImageUris ImageUris { get; set; }

	[JsonPropertyName("card_faces")]
	public List<CardFace> CardFaces { get; set; }

	[JsonPropertyName("mana_cost")]
	public string ManaCost { get; set; }

	[JsonPropertyName("cmc")]
	public double Cmc { get; set; }

	[JsonPropertyName("colors")]
	public List<string> Colors { get; set; }

	[JsonPropertyName("color_identity")]
	public List<string> ColorIdentity { get; set; }

	[JsonPropertyName("color_indicator")]
	public List<string> ColorIndicator { get; set; }

	[JsonPropertyName("oracle_text")]
	public string OracleText { get; set; }

	[JsonPropertyName("printed_text")]
	public string PrintedText { get; set; }

	[JsonPropertyName("type_line")]
	public string TypeLine { get; set; }

	[JsonPropertyName("printed_type_line")]
	public string PrintedTypeLine { get; set; }

	[JsonPropertyName("power")]
	public string Power { get; set; }

	[JsonPropertyName("toughness")]
	public string Toughness { get; set; }

	[JsonPropertyName("loyalty")]
	public string Loyalty { get; set; }

	[JsonPropertyName("flavor_name")]
	public string FlavorName { get; set; }

	[JsonPropertyName("flavor_text")]
	public string FlavorText { get; set; }

	[JsonPropertyName("artist")]
	public string Artist { get; set; }

	[JsonPropertyName("artist_ids")]
	public List<Guid> ArtistIds { get; set; }

	[JsonPropertyName("illustration_id")]
	public Guid? IllustrationId { get; set; }

	[JsonPropertyName("border_color")]
	public string BorderColor { get; set; }

	[JsonPropertyName("frame")]
	public string Frame { get; set; }

	[JsonPropertyName("frame_effects")]
	public List<string> FrameEffects { get; set; }

	[JsonPropertyName("full_art")]
	public bool FullArt { get; set; }

	[JsonPropertyName("textless")]
	public bool Textless { get; set; }

	[JsonPropertyName("booster")]
	public bool Booster { get; set; }

	[JsonPropertyName("reserved")]
	public bool Reserved { get; set; }

	[JsonPropertyName("promo")]
	public bool Promo { get; set; }

	[JsonPropertyName("promo_types")]
	public List<string> PromoTypes { get; set; }

	[JsonPropertyName("reprint")]
	public bool Reprint { get; set; }

	[JsonPropertyName("rarity")]
	public string Rarity { get; set; }

	[JsonPropertyName("variation")]
	public bool Variation { get; set; }

	[JsonPropertyName("variation_of")]
	public string VariationOf { get; set; }

	[JsonPropertyName("set_id")]
	public Guid SetId { get; set; }

	[JsonPropertyName("set")]
	public string Set { get; set; }

	[JsonPropertyName("set_name")]
	public string SetName { get; set; }

	[JsonPropertyName("set_type")]
	public string SetType { get; set; }

	[JsonPropertyName("set_uri")]
	public string SetUri { get; set; }

	[JsonPropertyName("set_search_uri")]
	public string SetSearchUri { get; set; }

	[JsonPropertyName("scryfall_set_uri")]
	public string ScryfallSetUri { get; set; }

	[JsonPropertyName("rulings_uri")]
	public string RulingsUri { get; set; }

	[JsonPropertyName("prints_search_uri")]
	public string PrintsSearchUri { get; set; }

	[JsonPropertyName("collector_number")]
	public string CollectorNumber { get; set; }

	[JsonPropertyName("digital")]
	public bool Digital { get; set; }

	[JsonPropertyName("foil")]
	public bool Foil { get; set; }

	[JsonPropertyName("nonfoil")]
	public bool Nonfoil { get; set; }

	[JsonPropertyName("finishes")]
	public List<string> Finishes { get; set; }

	[JsonPropertyName("games")]
	public List<string> Games { get; set; }

	[JsonPropertyName("oversized")]
	public bool Oversized { get; set; }

	[JsonPropertyName("produced_mana")]
	public List<string> ProducedMana { get; set; }

	[JsonPropertyName("legalities")]
	public Legalities Legalities { get; set; }

	[JsonPropertyName("story_spotlight")]
	public bool StorySpotlight { get; set; }

	[JsonPropertyName("edhrec_rank")]
	public int? EdhrecRank { get; set; }

	[JsonPropertyName("penny_rank")]
	public int? PennyRank { get; set; }

	[JsonPropertyName("prices")]
	public Prices Prices { get; set; }

	[JsonPropertyName("related_uris")]
	public RelatedUris RelatedUris { get; set; }

	[JsonPropertyName("purchase_uris")]
	public PurchaseUris PurchaseUris { get; set; }

	[JsonPropertyName("all_parts")]
	public List<RelatedPart> AllParts { get; set; }

	[JsonPropertyName("security_stamp")]
	public string? SecurityStamp { get; set; }



}
