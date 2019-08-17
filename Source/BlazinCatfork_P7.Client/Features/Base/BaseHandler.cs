namespace BlazinCatFork_P7.Client.Features.Base
{
  using BlazinCatFork_P7.Client.Features.Application;
  using BlazinCatFork_P7.Client.Features.Counter;
  using BlazinCatFork_P7.Client.Features.WeatherForecast;
  using BlazinCatFork_P7.Client.Features.EventStream;
  using BlazorState;
  using MediatR;
  using BlazinCatFork_P7.Client.Features.CatPic;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TState"></typeparam>
  internal abstract class BaseHandler<TRequest, TState> : BlazorState.RequestHandler<TRequest, TState>
    where TRequest : IRequest<TState>
    where TState : IState
  {
    public BaseHandler(IStore aStore) : base(aStore) { }

    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();
    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();
    protected CounterState CounterState => Store.GetState<CounterState>();
    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();
    protected CatPicState CatPicState => Store.GetState<CatPicState>();
  }
}