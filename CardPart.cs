using System.Text.Json.Serialization;

namespace ScryfallObjects;

public class CardPart {
	public CardPart(string @object, Guid id, string component, string name, string typeLine, string uri) {
		Object = @object;
		Id = id;
		Component = component;
		Name = name;
		TypeLine = typeLine;
		Uri = uri;
	}

	[JsonPropertyName("object")]
	public string Object { get; set; }

	[JsonPropertyName("id")]
	public Guid Id { get; set; }

	[JsonPropertyName("component")]
	public string Component { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("type_line")]
	public string TypeLine { get; set; }

	[JsonPropertyName("uri")]
	public string Uri { get; set; }
}
