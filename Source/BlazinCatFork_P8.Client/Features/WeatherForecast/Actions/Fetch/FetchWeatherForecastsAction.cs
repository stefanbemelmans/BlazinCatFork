namespace BlazinCatFork_P8.Client.Features.WeatherForecast
{
  using MediatR;

  public class FetchWeatherForecastsAction : IRequest<WeatherForecastsState> { }
}