namespace Surveil;
public enum Format {
	None,
	Standard,
	Modern,
	Pioneer,
	Vintage,
	Legacy,
	Pauper,
	TwoHeadedGiant,
	Commander1v1,
	Brawl,
	Freeform,
	Momir,
	PennyDreadful,
	Prismatic,
	Singlton,
	TribalWars,
	CubeDraft,
	Alchemy,
	ArenaStandard,
	Artisan,
	Gladiator,
	Historic,
	Mastermind,
	MomirsMadness,
	MomirPlaneswalker,
	OkosMadness,
	SleeperAgent,
	StandardCascade,
	Timeless,
	Traditional,
	Card3Blind,
	Ancient,
	Archenemy,
	Commander,
	DuelCommander,
	ForgetfulFish,
	Frontier,
	Highlander,
	JudgeTower,
	Oathbreaker,
	PauperCommander,
	TinyLeaders,
}
public class Deck {
	public required string Name { get; set; }
	public string? Description { get; set; }
	public char[]? ColorIdentity { get; set; }
	public required Format Format { get; set; }
	public required CardCollection LegalCards { get; set; }

	public required CardCollection MainBoard { get; set; }
	public required CardCollection SideBoard { get; set; }
	public required CardCollection MaybeBoard { get; set; }
}
