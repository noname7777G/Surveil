using System.Text.Json.Serialization;

namespace Surveil.CardPart {
	public class Preview {
		[JsonPropertyName("previewed_at")]
		[JsonConverter(typeof(ScryfallDateConverter))]
		public DateTime? PreviewedAt { get; set; }
		[JsonPropertyName("source_uri")]
		public Uri? SourceUri { get; set; }
		[JsonPropertyName("source")]
		public string? Source { get; set; }
	}
}