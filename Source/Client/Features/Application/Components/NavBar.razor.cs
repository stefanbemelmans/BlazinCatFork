namespace BlazinCatfork.Client.Features.Application.Components
{
  using BlazinCatfork.Client.Features.Base.Components;
  using static BlazinCatfork.Client.Features.Application.ApplicationState;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";

    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}