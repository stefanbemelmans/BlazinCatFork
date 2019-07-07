namespace BlazinCatFork.Client.Features.Application.Components
{
  using BlazinCatFork.Client.Features.Base.Components;

  public class FooterModel: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
