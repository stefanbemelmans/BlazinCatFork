namespace BlazinCatFork_P8.Client.Pages
{
  using System.Threading.Tasks;
  using BlazinCatFork_P8.Client.Features.Base.Components;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new Features.WeatherForecast.FetchWeatherForecastsAction());
  }
}