namespace Surveil;
internal class Deck {
	public enum Format {

	}

	public string Name { get; set; }
	public string Description { get; set; }
	public char[] ColorIdentity { get; set; }
	public CardCollection LegalCards { get; private set; }

	public CardCollection MainBoard { get; private set; }
	public CardCollection SideBoard { get; private set; }
	public CardCollection MaybeBoard { get; private set; }

}
