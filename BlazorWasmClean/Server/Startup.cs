using BlazorWasmClean.Application;
using BlazorWasmClean.Application.Common.Interfaces;
using BlazorWasmClean.Infrastructure;
using BlazorWasmClean.Infrastructure.Persistence;
using BlazorWasmClean.Server.Filters;
using BlazorWasmClean.Server.Services;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorWasmClean.Server
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddApplication();
			services.AddInfrastructure(Configuration);

			services.AddDatabaseDeveloperPageExceptionFilter();
			services.AddSingleton<ICurrentUserService, CurrentUserService>();
			services.AddHttpContextAccessor();
			services.AddHealthChecks().AddDbContextCheck<ApplicationDbContext>();
			services
				.AddControllersWithViews(options => options.Filters.Add<ApiExceptionFilterAttribute>())
				.AddFluentValidation();
			services.AddRazorPages();
			services.AddSwaggerGen();

			// State Management
			services.AddScoped<Client.StateContainer>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseMigrationsEndPoint();
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHealthChecks("/health");
			app.UseHttpsRedirection();
			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlazorWasmClean API V1");
			});

			app.UseRouting();

			app.UseIdentityServer();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
				endpoints.MapFallbackToFile("index.html");
			});
		}
	}
}
