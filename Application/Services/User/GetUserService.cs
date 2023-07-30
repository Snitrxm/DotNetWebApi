using Domain.Contracts.Repositories;
using Domain.Contracts.Services.UserServices;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services.User {
  public class GetUserService : IGetUserService
  {
    private readonly IUsersRepository _usersRepository;

    public GetUserService(IUsersRepository usersRepository){
      _usersRepository = usersRepository;
    }

    public IActionResult Execute(Guid id)
    {
      var user = _usersRepository.FindById(id);
      return new OkObjectResult(user);
    }
  }
}