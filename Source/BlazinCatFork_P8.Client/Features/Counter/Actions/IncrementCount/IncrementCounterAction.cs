namespace BlazinCatFork_P8.Client.Features.Counter
{
  using MediatR;
  using BlazinCatFork_P8.Shared.Features.Base;

  public class IncrementCounterAction : BaseRequest, IRequest<CounterState>
  {
    public int Amount { get; set; }
  }
}