using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MySecondNiceBlazorApp;
using MudBlazor.Services;
using MySecondNiceBlazorApp.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

builder.Services.AddScoped<ICatalog, InMemoryCatalog>();
builder.Services.AddScoped<ICart, Cart>();
await builder.Build().RunAsync();
