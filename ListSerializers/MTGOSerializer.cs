
namespace Surveil.ListSerializers;
public class MTGOSerializer : IListSerializer {
	public static readonly MTGOSerializer Instance = new();

	public Deck LoadText(IEnumerable<string> list, CardCollection loadedCards) {
		Deck deck = new("", loadedCards, Format.None);

		IEnumerable<string> mainBoardList = list.TakeWhile(line => line != "");

		foreach(string line in mainBoardList) {
			deck.MainBoard.AddRange(ParseCards(line, loadedCards));
		}

		IEnumerable<string> sideBoardList = list.SkipWhile(line => line != "SIDEBOARD:");
		sideBoardList = sideBoardList.Skip(1);
		sideBoardList = sideBoardList.TakeWhile(line => line != "");

		foreach(string line in sideBoardList) {
			deck.SideBoard.AddRange(ParseCards(line, loadedCards));
		}

		if(sideBoardList.Last() != list.Last()) {
			IEnumerable<string> commanderLines = list.TakeLast(2);
			string commanderAName = commanderLines.ElementAt(1).Split(' ', 2)[1];
			deck.CommanderA = loadedCards.GetCardByName(commanderAName) ?? throw new ListSerializerException();

			if(commanderLines.First() != "") {
				string commanderBName = commanderLines.First().Split(' ', 2)[1];
				deck.CommanderB = loadedCards.GetCardByName(commanderBName) ?? throw new ListSerializerException();
			}
		}
		return deck;
	}

	private static IEnumerable<Card> ParseCards(string line, CardCollection loadedCards) {
		string[] splitLine = line.Split(' ', 2);
		if(!int.TryParse(splitLine[0], out int quantity)) { throw new ListSerializerException(); }
		Card card = loadedCards.GetCardByName(splitLine[1]) ?? throw new ListSerializerException();

		return Enumerable.Repeat(card, quantity);
	}

	public string ToText(Deck deck) {
		throw new NotImplementedException();
	}
}
