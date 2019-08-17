namespace BlazinCatFork_P7.Client.Features.Application.Components
{
  using BlazinCatFork_P7.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
