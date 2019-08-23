namespace BlazinCatFork_P8.Client.Features.FluentValidation
{
  using global::FluentValidation;
  using global::FluentValidation.Internal;
  using global::FluentValidation.Results;
  using Microsoft.AspNetCore.Components.Forms;
  using System;
  using System.Linq;
  using System.Reflection;

  public static class EditContextFluentValidationExtensions
  {
    public static EditContext AddFluentValidation(this EditContext aEditContext)
    {
      if (aEditContext == null)
      {
        throw new ArgumentNullException(nameof(aEditContext));
      }

      var messages = new ValidationMessageStore(aEditContext);

      aEditContext.OnValidationRequested +=
          (aSender, aEventArgs) => ValidateModel((EditContext)aSender, messages);

      aEditContext.OnFieldChanged +=
          (aSender, aEventArgs) => ValidateField(aEditContext, messages, aEventArgs.FieldIdentifier);

      return aEditContext;
    }

    private static void ValidateModel(EditContext aEditContext, ValidationMessageStore aMessages)
    {
      IValidator validator = GetValidatorForModel(aEditContext.Model);
      ValidationResult validationResults = validator.Validate(aEditContext.Model);

      aMessages.Clear();
      foreach (ValidationFailure validationResult in validationResults.Errors)
      {
        aMessages.Add(aEditContext.Field(validationResult.PropertyName), validationResult.ErrorMessage);
      }

      aEditContext.NotifyValidationStateChanged();
    }

    private static void ValidateField(EditContext aEditContext, ValidationMessageStore aMessageStore, in FieldIdentifier aFieldIdentifier)
    {
      string[] properties = new[] { aFieldIdentifier.FieldName };
      var context = new ValidationContext(aFieldIdentifier.Model, new PropertyChain(), new MemberNameValidatorSelector(properties));

      IValidator validator = GetValidatorForModel(aFieldIdentifier.Model);
      ValidationResult validationResults = validator.Validate(context);

      aMessageStore.Clear(aFieldIdentifier);
      aMessageStore.AddRange(aFieldIdentifier, validationResults.Errors.Select(aError => aError.ErrorMessage));

      aEditContext.NotifyValidationStateChanged();
    }

    private static IValidator GetValidatorForModel(object aModel)
    {
      Type abstractValidatorType = typeof(AbstractValidator<>).MakeGenericType(aModel.GetType());
      Type modelValidatorType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(aT => aT.IsSubclassOf(abstractValidatorType));
      var modelValidatorInstance = (IValidator)Activator.CreateInstance(modelValidatorType);

      return modelValidatorInstance;
    }
  }
}
