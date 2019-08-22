namespace BlazinCatFork_P8.Shared.Features.WeatherForecast
{
  using BlazinCatFork_P8.Shared.Features.Base;
  using MediatR;

  public class GetWeatherForecastsRequest : BaseRequest, IRequest<GetWeatherForecastsResponse>
  {
    public const string Route = "api/weatherForecast";
    public string RouteWithQueryString => $"{Route}?days={Days}";
    /// <summary>
    /// The Number of days of forecasts to get
    /// </summary>
    public int Days { get; set; }
  }
}