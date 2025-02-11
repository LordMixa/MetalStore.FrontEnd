using AutoMapper;
using MetalStore.FrontEnd.Core.Contracts;
using MetalStore.FrontEnd.UI.ViewModels;

namespace MetalStore.FrontEnd.UI.MapperConfigurations;

public class ViewModelsMappingProfile : Profile
{
    public ViewModelsMappingProfile()
    {
        CreateMap<ClothingItem, ClothingItemViewModel>();
    }
}
