namespace BlazinCatFork_P8.Client.Features.Recipes.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using System;
  using System.ComponentModel.DataAnnotations;

  public class RecipeSearchFormBase : BaseComponent
    {
    [Required]
    public int number { get; set; } = 5; // Of Recipes
    [Required]
    [Range(1,2, ErrorMessage="Just One or the Other!")]
    public int ranking { get; set; } = 1; // Whether to maximize used ingredients (1) or minimize missing ingredients (2) first.
    [Required]
    public bool ignorePantry { get; set; } = true;
    [Required(ErrorMessage="Please Enter at Least One Ingredient!")]
    public string ingredients { get; set; }

  }
}
