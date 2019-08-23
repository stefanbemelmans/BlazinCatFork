namespace BlazinCatFork_P8.Client.Features.Recipes.Components
{
  using BlazinCatFork_P8.Client.Features.Base.Components;
  using BlazinCatFork_P8.Shared.Features.SpoonacularApi;
  using System;
  
  public class RecipeSearchFormBase : BaseComponent
  {

    public SharedRecipeSearchRequest RecipeSearchFormInputs { get; set; } = new SharedRecipeSearchRequest() 
    {
      ingredients = "chicken, onions"
    };
   
    
    public void SumbitValidForm()
    {
      Console.WriteLine("Form Submitted Successfully!");
      Console.WriteLine($"{RecipeSearchFormInputs.ignorePantry}");
      Console.WriteLine($"{RecipeSearchFormInputs.ranking}");
      Console.WriteLine($"{RecipeSearchFormInputs.number}");
      Console.WriteLine($"{RecipeSearchFormInputs.ingredients}");

      //foreach(object formValue in RecipeSearchFormInputs.GetType().GetProperties())
      //{
      //  Console.WriteLine($"{formValue.GetType().ToString()}: {RecipeSearchFormInputs.GetType().Get[formValue]} ");
      //}
    }
  }
}