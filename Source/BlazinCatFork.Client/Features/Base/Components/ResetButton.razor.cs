namespace BlazinCatFork.Client.Features.Base.Components
{
  using BlazinCatFork.Client.Features.Application;

  public class ResetButtonModel : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}