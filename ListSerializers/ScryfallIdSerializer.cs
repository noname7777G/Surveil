namespace Surveil.ListSerializers;
public class ScryfallIdSerializer : IListSerializer {
	public static readonly ScryfallIdSerializer Instance = new();
	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		throw new NotImplementedException();
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
