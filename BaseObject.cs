using System;
using System.Text.Json.Serialization;
namespace ScryfallObjects;
public abstract class BaseObject{
	public BaseObject(string objectType) {
		ObjectType = objectType;
	}

	[JsonPropertyName("object")]
	public string ObjectType {  get; set; }
}
