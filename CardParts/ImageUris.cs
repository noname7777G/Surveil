using System.Text.Json.Serialization;

namespace Surveil.CardParts;
/// <summary>
/// An object providing URIs to imagery for this face, if this is a double-sided card. 
/// <para>If this card is not double-sided, then the image_uris property will be part of the parent object instead.</para>
/// </summary>
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
