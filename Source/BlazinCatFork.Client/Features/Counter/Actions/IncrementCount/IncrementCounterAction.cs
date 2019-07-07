namespace BlazinCatFork.Client.Features.Counter
{
  using MediatR;
  using BlazinCatFork.Shared.Features.Base;

  public class IncrementCounterAction : BaseRequest, IRequest<CounterState>
  {
    public int Amount { get; set; }
  }
}