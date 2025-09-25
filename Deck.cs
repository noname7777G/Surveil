using Surveil.ListSerializers;

namespace Surveil;

//TODO: Base this off of the keys in the legalities dictionary.
public enum Format {
	None,
	Standard,
	Modern,
	Pioneer,
	Vintage,
	Legacy,
	Pauper,
	TwoHeadedGiant,
	Commander1v1,
	Brawl,
	Freeform,
	Momir,
	PennyDreadful,
	Prismatic,
	Singlton,
	TribalWars,
	CubeDraft,
	Alchemy,
	ArenaStandard,
	Artisan,
	Gladiator,
	Historic,
	Mastermind,
	MomirsMadness,
	MomirPlaneswalker,
	OkosMadness,
	SleeperAgent,
	StandardCascade,
	Timeless,
	Traditional,
	Card3Blind,
	Ancient,
	Archenemy,
	Commander,
	DuelCommander,
	ForgetfulFish,
	Frontier,
	Highlander,
	JudgeTower,
	Oathbreaker,
	PauperCommander,
	TinyLeaders,
}
public class Deck {
	public required string Name { get; set; }
	public string? Description { get; set; }
	public char[]? ColorIdentity { get; set; }
	public required Format Format { get; set; }
	public required CardCollection LegalCards { get; set; }

	public required CardCollection MainBoard { get; set; }
	public required CardCollection SideBoard { get; set; }
	public required CardCollection MaybeBoard { get; set; }

	public Card[]? Commanders { get; set; }
	public Card? Companion { get; set; }

	/// <summary>
	/// Sets <see cref="LegalCards.ParentCollection"/> to <paramref name="parent"/>.
	/// <para>Fills <see cref="LegalCards"/> with cards legal in the given <paramref name="format"/></para>
	/// </summary>
	/// <param name="name"></param>
	/// <param name="parent"></param>
	/// <param name="format"></param>
	public Deck(string name, CardCollection parent, Format format) {
		Name = name;
		LegalCards = parent.CreateSubCollection(format);
		Format = format;
	}

	public static Deck LoadFromFile(IListSerializer listSerializer, string path) {
		return listSerializer.LoadFile(path);
	}
	public static Deck LoadFromText(IListSerializer listSerializer, string list) {
		return listSerializer.LoadText(list);
	}

	public void SaveToFile(IListSerializer listSerializer, string path) {
		listSerializer.SaveFile(path, this);
	}
	public string SaveToText(IListSerializer listSerializer) {
		return listSerializer.ToText(this);
	}
}
