namespace BlazinCatfork_P7.Client.Features.Application.Components
{
  using BlazinCatfork_P7.Client.Features.Base.Components;

  public class SideBarBase: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  