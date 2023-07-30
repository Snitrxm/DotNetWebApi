using Domain.Contracts.Services.UserServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.CreateUser;

namespace WebApi.Controllers {
  [Route("/api/[controller]")]
  [ApiController]

  public class UsersController : ControllerBase {
    private readonly ICreateUserService _createUserService;
    private readonly IGetAllUsersService _getAllUsersService;

    public UsersController(
      ICreateUserService createUserService,
      IGetAllUsersService getAllUsersService
    ){
      _createUserService = createUserService;
      _getAllUsersService = getAllUsersService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var users = await _getAllUsersService.Execute();
      return users;
    }   

    [HttpPost]
    public Task<IActionResult> Create([FromBody] CreateUserInput createUserInput){
      var user = new User(Guid.NewGuid(), createUserInput.Name, createUserInput.Email);

      var response = _createUserService.Execute(user);

      return response;
    }
  }
}