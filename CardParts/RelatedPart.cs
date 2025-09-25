using System.Text.Json.Serialization;

namespace Surveil.CardParts;

public class RelatedPart {
	[JsonPropertyName("id")]
	public required Guid Id { get; set; }

	[JsonPropertyName("component")]
	public required string Component { get; set; }

	[JsonPropertyName("name")]
	public required string Name { get; set; }

	[JsonPropertyName("type_line")]
	public required string TypeLine { get; set; }

	[JsonPropertyName("uri")]
	public required Uri Uri { get; set; }
}
