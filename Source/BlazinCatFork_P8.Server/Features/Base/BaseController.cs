﻿namespace BlazinCatFork_P8.Server.Features.Base
{
  using System.Threading.Tasks;
  using BlazinCatFork_P8.Shared.Features.Base;
  using MediatR;
  using Microsoft.AspNetCore.Mvc;
  using Microsoft.Extensions.DependencyInjection;
  [ApiController]
  public class BaseController<TRequest, TResponse> : Controller
    where TRequest : IRequest<TResponse>
    where TResponse : BaseResponse
  {
    private IMediator _mediator;

    protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());

    protected virtual async Task<IActionResult> Send(TRequest aRequest)
    {
      TResponse response = await Mediator.Send(aRequest);

      return Ok(response);
    }
  }
}