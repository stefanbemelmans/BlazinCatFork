namespace BlazinCatfork.Client.Features.Counter
{
  using BlazinCatfork.Client.Features.Base;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}