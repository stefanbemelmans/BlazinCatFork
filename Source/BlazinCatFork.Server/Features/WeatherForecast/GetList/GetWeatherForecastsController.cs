namespace BlazinCatFork.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using BlazinCatFork.Server.Features.Base;
  using BlazinCatFork.Shared.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Get(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}