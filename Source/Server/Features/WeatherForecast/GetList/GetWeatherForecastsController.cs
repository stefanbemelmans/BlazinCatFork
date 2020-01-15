namespace BlazinCatfork.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using BlazinCatfork.Server.Features.Base;
  using BlazinCatfork.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Process(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}