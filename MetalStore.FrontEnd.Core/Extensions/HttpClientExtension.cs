using Newtonsoft.Json;

namespace MetalStore.FrontEnd.Core.Extensions;

public static class HttpClientExtension
{
    public static async Task<T?> GetAsync<T>(this HttpClient httpClient, string uri)
    {
        var response = await httpClient.GetAsync(uri);
        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();
        var obj = JsonConvert.DeserializeObject<T>(responseContent);

        return obj;
    }
}
