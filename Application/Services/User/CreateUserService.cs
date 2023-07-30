using Domain.Contracts.Repositories;
using Domain.Contracts.Services.UserServices;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.User {
  public class CreateUserService : ICreateUserService
  {
    private readonly IUsersRepository _usersRepository;

    public CreateUserService(IUsersRepository usersRepository){
      _usersRepository = usersRepository;
    }


    public async Task<IActionResult> Execute(Domain.Entities.User user)
    {
      var alreadyExist = _usersRepository.FindByEmail(user.Email);

      if (alreadyExist != null){
        return new BadRequestObjectResult("User Already Exist.");
      }

      await _usersRepository.Create(user);

      return new OkObjectResult(user);
    }
  }
}