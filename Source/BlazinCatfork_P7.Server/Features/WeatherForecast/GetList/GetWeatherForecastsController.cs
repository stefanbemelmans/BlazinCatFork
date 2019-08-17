namespace BlazinCatFork_P7.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using BlazinCatFork_P7.Server.Features.Base;
  using BlazinCatFork_P7.Shared.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Get(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}