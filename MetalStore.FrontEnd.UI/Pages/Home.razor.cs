using AutoMapper;
using MetalStore.FrontEnd.Core.Services.Interfaces;
using MetalStore.FrontEnd.UI.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MetalStore.FrontEnd.UI.Pages;

public partial class Home
{
    [Inject]
    private IClothingItemService ClothingItemService { get; set; } = default!;

    [Inject]
    private IMapper Mapper { get; set; } = default!;

    private IEnumerable<ClothingItemViewModel> ClothingItemViewModels = new List<ClothingItemViewModel>();

    protected override async Task OnInitializedAsync()
    {
        var clothingItems = await ClothingItemService.GetClothingItemsAsync();

        var clothingItemViewModels = Mapper.Map<IEnumerable<ClothingItemViewModel>>(clothingItems);

        ClothingItemViewModels = clothingItemViewModels;
    }
}
