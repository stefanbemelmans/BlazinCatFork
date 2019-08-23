using BlazinCatFork_P8.Client.Features.Recipes.Components;
using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazinCatFork_P8.Client.Features.Recipes.RecipeValidators
{
  public class RecipeSearchValidator : AbstractValidator<SharedRecipeSearchRequest>
  {
    public RecipeSearchValidator()
    {
      RuleFor(aRequest => aRequest.number).NotEmpty().GreaterThanOrEqualTo(5).WithMessage("Five recipes is default");
      RuleFor(aRequest => aRequest.ranking).NotEmpty().Must(aRanking => aRanking == 1 || aRanking == 2).WithMessage("Prioritize your Ingredients or minimize the others.");
      RuleFor(aRequest => aRequest.ignorePantry).NotEmpty().WithMessage("True is Default");
      RuleFor(aRequest => aRequest.ingredients).NotEmpty().MinimumLength(2).WithMessage("Please Enter At Least One Ingredient!");
    }
  }
}
