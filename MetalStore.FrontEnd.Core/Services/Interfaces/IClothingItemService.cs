using MetalStore.FrontEnd.Core.Contracts;

namespace MetalStore.FrontEnd.Core.Services.Interfaces;

public interface IClothingItemService
{
    public Task<IEnumerable<ClothingItem>?> GetClothingItemsAsync();
}
