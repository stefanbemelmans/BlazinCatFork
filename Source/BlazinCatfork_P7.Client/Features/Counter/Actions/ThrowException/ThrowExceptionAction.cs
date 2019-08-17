namespace BlazinCatfork_P7.Client.Features.Counter
{
  using MediatR;

  public class ThrowExceptionAction : IRequest<CounterState>
  {
    public string Message { get; set; }
  }
}