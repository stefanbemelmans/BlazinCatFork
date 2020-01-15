namespace BlazinCatfork.Client.Features.Counter.Components
{
  using System.Threading.Tasks;
  using BlazinCatfork.Client.Features.Base.Components;
  using static BlazinCatfork.Client.Features.Counter.CounterState;

  public class CounterBase : BaseComponent
  {
    protected async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}