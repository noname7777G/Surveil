namespace Surveil.ListSerializers;
public class MTGOSerializer : IListSerializer {
	public Deck LoadFile(string path) {
		throw new NotImplementedException();
	}

	public Deck LoadFile(FileStream fileStream) {
		throw new NotImplementedException();
	}

	public Deck LoadText(string list) {
		throw new NotImplementedException();
	}

	public Deck LoadText(IEnumerable<string> list) {
		throw new NotImplementedException();
	}

	public void SaveFile(string path, Deck deck) {
		throw new NotImplementedException();
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
