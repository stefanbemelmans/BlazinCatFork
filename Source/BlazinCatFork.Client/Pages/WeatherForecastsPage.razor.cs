﻿namespace BlazinCatFork.Client.Pages
{
  using System.Threading.Tasks;
  using BlazinCatFork.Client.Features.Base.Components;

  public class WeatherForecastsPageModel : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitAsync() =>
      await Mediator.Send(new Features.WeatherForecast.FetchWeatherForecastsAction());
  }
}