namespace BlazinCatFork.Client.Features.WeatherForecast
{
  using MediatR;

  public class FetchWeatherForecastsAction : IRequest<WeatherForecastsState> { }
}