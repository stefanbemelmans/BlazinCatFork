namespace BlazinCatfork_P7.Client.Features.Counter.Components
{
  using BlazinCatfork_P7.Client.Features.Base.Components;
  using BlazinCatfork_P7.Client.Features.Counter;
  using System.Threading.Tasks;

  public class CounterBase : BaseComponent
  {
    internal async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}