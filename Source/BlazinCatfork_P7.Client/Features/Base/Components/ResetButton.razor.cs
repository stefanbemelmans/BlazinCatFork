namespace BlazinCatfork_P7.Client.Features.Base.Components
{
  using BlazinCatfork_P7.Client.Features.Application;

  public class ResetButtonBase : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}