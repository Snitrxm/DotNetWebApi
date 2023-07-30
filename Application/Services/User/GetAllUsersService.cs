using Domain.Contracts.Repositories;
using Domain.Contracts.Services.UserServices;
using Microsoft.AspNetCore.Mvc;


namespace Application.Services.User {
  public class GetAllUsersService : IGetAllUsersService
  {
    private readonly IUsersRepository _usersRepository;

    public GetAllUsersService(IUsersRepository usersRepository){
      _usersRepository = usersRepository;
    }

    public async Task<IActionResult> Execute()
    {
        var users = await _usersRepository.FindAll();
        return new OkObjectResult(users);
    }
  }
}