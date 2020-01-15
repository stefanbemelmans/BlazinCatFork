namespace BlazinCatfork.Client.Features.EventStream
{
  using BlazinCatfork.Client.Features.Base;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}