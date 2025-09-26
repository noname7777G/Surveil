
namespace Surveil.ListSerializers;
public class MoxfieldSerializer : IListSerializer {
	public static readonly MoxfieldSerializer Instance = new();
	//TODO: Implement MoxfieldSerializer.LoadText().
	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		throw new NotImplementedException();
	}
	//TODO: Implement MoxfieldSerializer.ToText().
	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}

}
