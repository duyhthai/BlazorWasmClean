using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorWasmClean.Application.Common.Security;
using BlazorWasmClean.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasmClean.Server.Controllers
{
	[Authorize]
	public class WeatherForecastController : ApiControllerBase
	{
		[HttpGet]
		public async Task<IEnumerable<WeatherForecast>> Get()
		{
			return await Mediator.Send(new GetWeatherForecastsQuery());
		}
	}
}
