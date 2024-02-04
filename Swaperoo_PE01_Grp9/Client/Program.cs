using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Swaperoo_PE01_Grp9.Client;
using Swaperoo_PE01_Grp9.Client.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Swaperoo_PE01_Grp9.ServerAPI", (sp, client) => {client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); client.EnableIntercept(sp);})
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Swaperoo_PE01_Grp9.ServerAPI"));

builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();

builder.Services.AddApiAuthorization();



await builder.Build().RunAsync();
