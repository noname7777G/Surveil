using System.Text.Json.Serialization;

namespace Surveil.CardParts {
	public class Preview {
		[JsonPropertyName("previewed_at")]
		[JsonConverter(typeof(ScryfallDateConverter))]
		public DateTime? PreviewedAt { get; set; }
		[JsonPropertyName("source_uri")]
		public required Uri SourceUri { get; set; }
		[JsonPropertyName("source")]
		public required string Source { get; set; }
	}
}