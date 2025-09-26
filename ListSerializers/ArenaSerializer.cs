

namespace Surveil.ListSerializers;
public class ArenaSerializer : IListSerializer {
	public static readonly ArenaSerializer Instance = new();
	//TODO: Implement ArenaSerializer.LoadText().
	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		throw new NotImplementedException();
	}
	//TODO: Implement ArenaSerializer.ToText().
	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
