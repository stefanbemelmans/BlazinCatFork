namespace BlazinCatFork_P7.Client.Pages
{
  using System.Threading.Tasks;
  using BlazinCatFork_P7.Client.Features.Base.Components;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitAsync() =>
      await Mediator.Send(new Features.WeatherForecast.FetchWeatherForecastsAction());
  }
}