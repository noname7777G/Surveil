

namespace Surveil.ListSerializers;
public class ArenaSerializer : IListSerializer {
	public static readonly ArenaSerializer Instance = new();

	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		throw new NotImplementedException();
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
