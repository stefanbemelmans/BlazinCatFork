using BlazinCatFork_P8.Shared.Features.Base;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazinCatFork_P8.Client.Features.Recipes.Actions
{
  public class RecipeSearchAction : BaseRequest, IRequest<RecipeState>
  {
    public bool ignorePantry { get; set; } = true;
    public string ingredients { get; set; }
    public int number { get; set; } = 5; // Of Recipes
    public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.


  }
}