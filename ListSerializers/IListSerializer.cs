namespace Surveil.ListSerializers;
public interface IListSerializer {
	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards);

	public string ToText(Deck deck);
	public void SaveFile(string path, Deck deck) {
		File.WriteAllText(path, ToText(deck));
	}
}

public static class ListSerializerExtentions {
	public static Deck LoadFile(this IListSerializer listSerializer, string path, CardCollection loadedCards) {
		string list = File.ReadAllText(path);
		return listSerializer.LoadText(list, loadedCards);
	}

	public static Deck LoadText(this IListSerializer listSerializer, string list, CardCollection loadedCards) {
		return listSerializer.LoadText(list.Split('\n'), loadedCards);
	}

	public static void SaveFile(this IListSerializer listSerializer, string path, Deck deck) {
		File.WriteAllText(path, listSerializer.ToText(deck));
	}
}

internal class ListSerializerException : Exception {
	public ListSerializerException() {
	}

	public ListSerializerException(string? message) : base(message) {
	}

	public ListSerializerException(string? message, Exception? innerException) : base(message, innerException) {
	}
}
