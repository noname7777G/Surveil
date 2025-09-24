using System.Text.Json.Serialization;

namespace Surveil.CardParts;

public class ImageUris {
	[JsonPropertyName("small")]
	public required string Small { get; set; }

	[JsonPropertyName("normal")]
	public required string Normal { get; set; }

	[JsonPropertyName("large")]
	public required string Large { get; set; }

	[JsonPropertyName("png")]
	public required string Png { get; set; }

	[JsonPropertyName("art_crop")]
	public required string ArtCrop { get; set; }

	[JsonPropertyName("border_crop")]
	public required string BorderCrop { get; set; }
}
