namespace BlazinCatfork.Client.Pages
{
  using System.Threading.Tasks;
  using BlazinCatfork.Client.Features.Base.Components;
  using static BlazinCatfork.Client.Features.WeatherForecast.WeatherForecastsState;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new FetchWeatherForecastsAction());
  }
}