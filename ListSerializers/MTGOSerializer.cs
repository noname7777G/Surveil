
namespace Surveil.ListSerializers;
public class MTGOSerializer : IListSerializer {
	public static readonly MTGOSerializer Instance = new();

	public Deck LoadText(IEnumerable<string> list) {
		throw new NotImplementedException();
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
