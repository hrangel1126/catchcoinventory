using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Inventory.Client;
using Inventory.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var BaseAddress = new Uri(builder.HostEnvironment.IsDevelopment() ? "http://localhost:5117/" : builder.HostEnvironment.BaseAddress);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = BaseAddress });
builder.Services.AddScoped<StockService>();


await builder.Build().RunAsync();
