namespace BlazinCatFork_P7.Client.Features.Counter
{
  using MediatR;
  using BlazinCatFork_P7.Shared.Features.Base;

  public class IncrementCounterAction : BaseRequest, IRequest<CounterState>
  {
    public int Amount { get; set; }
  }
}