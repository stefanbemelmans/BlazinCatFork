namespace BlazinCatFork_P8.Client.Features.Application.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}
