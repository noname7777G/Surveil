namespace Surveil;
public interface IListSerializer {
	public Deck LoadText(string list);
	public Deck LoadText(IEnumerable<string> list);
	public Deck LoadFile(String path);
	public Deck LoadFile(FileStream fileStream);

	public string ToText(Deck deck);
	public void SaveFile(string path, Deck deck);
}

