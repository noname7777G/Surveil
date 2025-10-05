namespace Surveil.Retrievers;
public static class WebClient {
	internal static readonly HttpClient client = new();

	public static string UserAgent {
		get {
			if(client.DefaultRequestHeaders.TryGetValues("User-Agent", out IEnumerable<string>? keys)) {
				return keys.First();
			} else {
				return "";
			}
		}
		set {
			if(value == null || value == "") {
				throw new DataRetrievalException("User-Agent cannot be empty or null");
			}
			client.DefaultRequestHeaders.Remove("User-Agent");
			client.DefaultRequestHeaders.Add("User-Agent", value);
		}
	}

	public async static Task<HttpResponseMessage> GetBuffered(string uri) {
		if(!client.DefaultRequestHeaders.TryGetValues("User-Agent", out _)) { throw new DataRetrievalException($"Tried to fetch data with no User-Agent set."); }
		HttpRequestMessage httpRequestMessage = new(HttpMethod.Get, uri);

		HttpResponseMessage response = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
		response.EnsureSuccessStatusCode();
		await Task.Delay(100);

		return response;
	}

	static WebClient() {
		client.DefaultRequestHeaders.Add("Accept", "application/json");
	}
}

public class DataRetrievalException : Exception {
	public DataRetrievalException() { }
	public DataRetrievalException(string? message) : base(message) { }
	public DataRetrievalException(string? message, Exception? innerException) : base(message, innerException) { }
}
