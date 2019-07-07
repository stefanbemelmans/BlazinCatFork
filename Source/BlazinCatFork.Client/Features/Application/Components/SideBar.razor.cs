namespace BlazinCatFork.Client.Features.Application.Components
{
  using BlazinCatFork.Client.Features.Base.Components;

  public class SideBarModel: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  