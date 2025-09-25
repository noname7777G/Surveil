using System.Text.Json;
using System.Text.Json.Serialization;

namespace Surveil;

public class ScryfallLegalityConverter : JsonConverter<Dictionary<string, Legality>?> {
	public override Dictionary<string, Legality>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
		if(reader.TokenType != JsonTokenType.StartObject) { throw new JsonException(); }

		Dictionary<string, Legality> legalities = [];

		while(reader.Read()) {
			if(reader.TokenType == JsonTokenType.EndObject) { break; }
			if(reader.TokenType != JsonTokenType.PropertyName) { throw new JsonException($"Expect property name at {reader.BytesConsumed} bytes."); }

			string? propertyName = reader.GetString() ?? throw new JsonException($"Property name at {reader.BytesConsumed} bytes is null.");

			reader.Read();
			if(reader.TokenType != JsonTokenType.String) { throw new JsonException($"Value at {reader.BytesConsumed} bytes is not a string."); }
			string value = (string)(reader.GetString() ?? throw new JsonException($"Value at {reader.BytesConsumed} bytes is null."));

			legalities.Add(propertyName, value switch {
				"legal" => Legality.Legal,
				"not_legal" => Legality.NotLegal,
				"banned" => Legality.Banned,
				"restricted" => Legality.Restricted,
				_ => throw new JsonException($"Cannot convert {value} At {reader.BytesConsumed} bytes to {typeof(Legality)}."),
			});
		}
		return legalities;
	}
	public override void Write(Utf8JsonWriter writer, Dictionary<string, Legality>? value, JsonSerializerOptions options) {
		throw new NotImplementedException();
	}
}

public class ScryfallPricesConverter : JsonConverter<Dictionary<string, Decimal?>> {
	public override Dictionary<string, decimal?> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
		if(reader.TokenType != JsonTokenType.StartObject) { throw new JsonException(); }

		Dictionary<string, Decimal?> prices = [];

		while(reader.Read()) {
			if(reader.TokenType == JsonTokenType.EndObject) { break; }
			if(reader.TokenType != JsonTokenType.PropertyName) { throw new JsonException($"Expect property name at {reader.BytesConsumed} bytes."); }

			string? propertyName = reader.GetString() ?? throw new JsonException($"Property name at {reader.BytesConsumed} bytes is null.");

			reader.Read();
			string? value = reader.GetString();

			if(value == null) {
				prices.Add(propertyName, null);
				continue;
			} else if(Decimal.TryParse(value, out Decimal decimalValue)) {
				prices.Add(propertyName, decimalValue);
			} else {
				throw new JsonException($"Value at {reader.BytesConsumed} is not a number.");
			}
		}
		return prices;
	}

	public override void Write(Utf8JsonWriter writer, Dictionary<string, decimal?> value, JsonSerializerOptions options) {
		throw new NotImplementedException();
	}
}

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
