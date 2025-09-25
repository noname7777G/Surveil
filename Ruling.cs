
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surveil;
public class Ruling {
	[JsonPropertyName("oracle_id")]
	public required Guid OracleId { get; set; }
	[JsonPropertyName("source")]
	public required string Source { get; set; }
	[JsonPropertyName("published_at")]
	public required string PublishedAt { get; set; }
	[JsonPropertyName("comment")]
	public required string Comment { get; set; }

	public static List<Ruling> LoadRullings(string bulkDataPath) {
		string jsonIn = File.ReadAllText(bulkDataPath);
		List<Ruling> rulings = JsonSerializer.Deserialize<List<Ruling>>(jsonIn) ?? throw new Exception("Could not load rulings data");
		return rulings;
	}
}
