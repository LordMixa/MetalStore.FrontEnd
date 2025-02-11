using MetalStore.FrontEnd.Core.Contracts;
using MetalStore.FrontEnd.Core.Extensions;
using MetalStore.FrontEnd.Core.Services.Interfaces;

namespace MetalStore.FrontEnd.Core.Services;

public class ClothingItemService : IClothingItemService
{
    private readonly HttpClient _httpClient;

    public ClothingItemService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<ClothingItem>?> GetClothingItemsAsync()
    {
        var clothingItems = await _httpClient.GetAsync<IEnumerable<ClothingItem>>("api/clothing-items");

        return clothingItems;
    }
}
