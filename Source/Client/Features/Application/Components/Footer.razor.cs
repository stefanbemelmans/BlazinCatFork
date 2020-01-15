namespace BlazinCatfork.Client.Features.Application.Components
{
  using BlazinCatfork.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
