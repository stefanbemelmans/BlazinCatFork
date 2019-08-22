namespace BlazinCatFork_P8.Client.Pipeline.NotificationPreProcessor
{
  using MediatR;

  public class PrePipelineNotification<TRequest> : INotification
  {
    public TRequest Request { get; set; }
  }
}
