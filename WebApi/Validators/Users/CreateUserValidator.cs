using FluentValidation;
using WebApi.Models.CreateUser;

namespace WebApi.Validators.Users {
   public class CreateUserValidator : AbstractValidator<CreateUserInput> {
    public CreateUserValidator(){
      RuleFor(u => u.Name)
        .NotEmpty()
        .WithMessage("Name must not be empty");
      
      RuleFor(u => u.Email)
        .EmailAddress()
        .WithMessage("Email should be a valid email");
    }
   }
}