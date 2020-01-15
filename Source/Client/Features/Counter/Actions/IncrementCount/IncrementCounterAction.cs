namespace BlazinCatfork.Client.Features.Counter
{
  using BlazinCatfork.Client.Features.Base;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}