namespace BlazinCatFork_P8.Client.Features.Counter
{
  using MediatR;

  public class ThrowExceptionAction : IRequest<CounterState>
  {
    public string Message { get; set; }
  }
}