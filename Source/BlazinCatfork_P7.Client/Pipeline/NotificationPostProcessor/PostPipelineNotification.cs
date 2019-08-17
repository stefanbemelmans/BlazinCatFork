﻿namespace BlazinCatFork_P7.Client.Pipeline.NotificationPostProcessor
{
  using MediatR;

  public class PostPipelineNotification<TRequest, TResponse> : INotification
  {
    public TRequest Request { get; set; }
    public TResponse Response { get; set; }
  }
}
