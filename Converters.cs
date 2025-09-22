using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surveil;
/// <summary>
/// Parses a Scryfall "released_at" date string (e.g. "2019-05-03") into DateTime?.
/// </summary>
public class ScryfallDateConverter : JsonConverter<DateTime?> {
	public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
		if(reader.TokenType == JsonTokenType.String) {
			var str = reader.GetString();
			if(DateTime.TryParse(str, out var dt))
				return dt;
			return null;
		}

		if(reader.TokenType == JsonTokenType.Null)
			return null;

		throw new JsonException($"Invalid date value for {typeToConvert}");
	}

	public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options) {
		if(value.HasValue)
			writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd"));
		else
			writer.WriteNullValue();
	}
}

/// <summary>
/// Converts Scryfall price strings (e.g. "1.23", null) into decimal?.
/// </summary>
public class ScryfallPriceConverter : JsonConverter<decimal?> {
	public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
		if(reader.TokenType == JsonTokenType.String) {
			var str = reader.GetString();
			if(decimal.TryParse(str, out var dec))
				return dec;
			return null;
		}

		if(reader.TokenType == JsonTokenType.Null)
			return null;

		throw new JsonException($"Invalid price value for {typeToConvert}");
	}

	public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options) {
		if(value.HasValue)
			writer.WriteStringValue(value.Value.ToString("0.00"));
		else
			writer.WriteNullValue();
	}
}
