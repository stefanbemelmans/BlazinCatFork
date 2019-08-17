namespace BlazinCatfork_P7.Client.Features.Application.Components
{
  using BlazinCatfork_P7.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
