using MetalStore.FrontEnd.Core.Services;
using MetalStore.FrontEnd.Core.Services.Interfaces;
using MetalStore.FrontEnd.UI.MapperConfigurations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace MetalStore.FrontEnd.UI;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddScoped(
            sp => new HttpClient 
            { 
                BaseAddress = new Uri(builder.Configuration["ApiSettings:BaseAddress"] ?? builder.HostEnvironment.BaseAddress)//TODO custom exception
            });

        builder.Services.AddAutoMapper(typeof(ViewModelsMappingProfile));
        builder.Services.AddTransient<IClothingItemService, ClothingItemService>();
        builder.Services.AddMudServices();

        await builder.Build().RunAsync();
    }
}
