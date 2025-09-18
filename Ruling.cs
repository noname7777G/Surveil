
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surveil;
public class Ruling : BaseObject {
	public Ruling(string objectType, string oracleId, string source, string publishedAt, string comment) : base(objectType) {
		this.OracleId = oracleId;
		this.Source = source;
		this.PublishedAt = publishedAt;
		this.Comment = comment;
	}

	[JsonPropertyName("oracle_id")]
	public string OracleId { get; set; }
	[JsonPropertyName("source")]
	public string Source { get; set; }
	[JsonPropertyName("published_at")]
	public string PublishedAt { get; set; }
	[JsonPropertyName("comment")]
	public string Comment { get; set; }

	public static List<Ruling> LoadRullings(string bulkDataPath) {
		string jsonIn = File.ReadAllText(bulkDataPath);
		List<Ruling> rulings = JsonSerializer.Deserialize<List<Ruling>>(jsonIn) ?? throw new Exception("Could not load rulings data");
		return rulings;
	}
}
