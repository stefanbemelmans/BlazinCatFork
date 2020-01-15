namespace BlazinCatfork.Client.Features.Application.Components
{
  using BlazinCatfork.Client.Features.Base.Components;

  public class SideBarBase: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  