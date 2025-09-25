
namespace Surveil.ListSerializers;
public class MoxfieldSerializer : IListSerializer {
	public static readonly MoxfieldSerializer Instance = new();

	public Deck LoadText(IEnumerable<string> list) {
		throw new NotImplementedException();
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
