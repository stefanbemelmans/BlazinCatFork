namespace BlazinCatFork_P8.Client.Features.Recipes.RecipeValidators
{
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using global::FluentValidation;

  public class RecipeSearchValidatorCollection : AbstractValidator<SharedRecipeSearchRequest>
  {
    public void RecipeSearchValidator()
    {
      RuleFor(aRequest => aRequest.Number).NotEmpty().GreaterThanOrEqualTo(5).WithMessage("Five recipes is default");
      RuleFor(aRequest => aRequest.Ranking).NotEmpty().Must(aRanking => aRanking == 1 || aRanking == 2).WithMessage("Prioritize your Ingredients or minimize the others.");
      RuleFor(aRequest => aRequest.IgnorePantry).NotEmpty().WithMessage("True is Default");
      RuleFor(aRequest => aRequest.Ingredients).NotEmpty().MinimumLength(2).WithMessage("Please Enter At Least One Ingredient!");
    }
  }
}
