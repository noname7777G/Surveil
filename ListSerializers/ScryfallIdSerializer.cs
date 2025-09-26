namespace Surveil.ListSerializers;
public class ScryfallIdSerializer : IListSerializer {
	public static readonly ScryfallIdSerializer Instance = new();
	//TODO: Implement ScryfallIdSerializer.LoadText().
	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		throw new NotImplementedException();
	}
	//TODO: Implement ScryfallIdSerializer.ToText().
	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
