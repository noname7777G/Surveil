namespace Surveil.ListSerializers;
public interface IListSerializer {
	public Deck LoadText(string list) {
		return LoadText(list.Split('\n'));
	}
	public Deck LoadText(IEnumerable<string> list);
	public Deck LoadFile(string path) {
		string list = File.ReadAllText(path);
		return LoadText(list);
	}

	public string ToText(Deck deck);
	public void SaveFile(string path, Deck deck) {
		File.WriteAllText(path, ToText(deck));
	}
}

