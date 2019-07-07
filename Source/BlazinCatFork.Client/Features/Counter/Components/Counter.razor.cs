namespace BlazinCatFork.Client.Features.Counter.Components
{
  using BlazinCatFork.Client.Features.Base.Components;
  using BlazinCatFork.Client.Features.Counter;

  public class CounterModel : BaseComponent
  {
    internal void ButtonClick() =>
      Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}