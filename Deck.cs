using Surveil.ListSerializers;

namespace Surveil;

//TODO: Base this off of the keys in the legalities dictionary.
public enum Format {
	None,
	Standard,
	Future,
	Historic,
	Timeless,
	Gladiator,
	Pioneer,
	Modern,
	Legacy,
	Pauper,
	Vintage,
	Penny,
	Commander,
	Oathbreaker,
	Standardbrawl,
	Brawl,
	Alchemy,
	Paupercommander,
	Duel,
	Oldschool,
	Premodern,
	Predh,
}
public class Deck {
	public string Name { get; set; }
	public string? Description { get; set; }
	public char[]? ColorIdentity { get; set; }
	public Format Format { get; set; }
	public CardCollection LegalCards { get; set; }

	public CardCollection MainBoard { get; set; }
	public CardCollection SideBoard { get; set; }
	public CardCollection MaybeBoard { get; set; }

	public Card? CommanderA { get; set; }
	public Card? CommanderB { get; set; }
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

		MainBoard = [];
		SideBoard = [];
		MaybeBoard = [];
	}

	public void SaveToFile(IListSerializer listSerializer, string path) {
		listSerializer.SaveFile(path, this);
	}
	public string SaveToText(IListSerializer listSerializer) {
		return listSerializer.ToText(this);
	}
}
