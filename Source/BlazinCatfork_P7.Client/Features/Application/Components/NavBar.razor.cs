namespace BlazinCatfork_P7.Client.Features.Application.Components
{
  using BlazinCatfork_P7.Client.Features.Base.Components;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}
