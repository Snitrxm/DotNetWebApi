using FluentValidation;
using FluentValidation.AspNetCore;
using WebApi.Validators.Users;

namespace WebApi.Configuration {
  public static class ControllerValidators {
    public static void RegisterControllersValidators(this IServiceCollection services){
      services.AddFluentValidationAutoValidation();
      services.AddFluentValidationClientsideAdapters();
      services.AddValidatorsFromAssemblyContaining<CreateUserValidator>();
    }

  }
}