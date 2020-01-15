﻿namespace BlazinCatfork.Api.Features.WeatherForecast
{
  using System;
  using System.Collections.Generic;
  using BlazinCatfork.Api.Features.Base;

  public class GetWeatherForecastsResponse : BaseResponse
  {
    /// <summary>
    /// a default constructor is required for deserialization
    /// </summary>
    public GetWeatherForecastsResponse() { }

    public GetWeatherForecastsResponse(Guid aRequestId)
    {
      WeatherForecasts = new List<WeatherForecastDto>();
      RequestId = aRequestId;
    }

    public List<WeatherForecastDto> WeatherForecasts { get; set; }
  }
}