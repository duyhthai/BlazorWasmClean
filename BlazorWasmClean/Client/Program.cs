using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWasmClean.Client
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services
				.AddHttpClient("BlazorWasmClean.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
				.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

			// Supply HttpClient instances that include access tokens when making requests to the server project
			builder.Services
				.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
				.CreateClient("BlazorWasmClean.ServerAPI"));

			builder.Services.AddApiAuthorization();

			builder.Services.AddSingleton<StateContainer>();

			await builder.Build().RunAsync();
		}
	}
}
