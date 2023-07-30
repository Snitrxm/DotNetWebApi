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

    private readonly IGetUserService _getUserService;

    public UsersController(
      ICreateUserService createUserService,
      IGetAllUsersService getAllUsersService,
      IGetUserService getUserService

    ){
      _createUserService = createUserService;
      _getAllUsersService = getAllUsersService;
      _getUserService = getUserService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var users = await _getAllUsersService.Execute();
      return users;
    }

    [HttpGet]
    [Route("{id:guid}")]
    public IActionResult GetUser([FromRoute] Guid id){
      var user = _getUserService.Execute(id);
      return user;
    }   

    [HttpPost]
    public Task<IActionResult> Create([FromBody] CreateUserInput createUserInput){
      var user = new User(Guid.NewGuid(), createUserInput.Name, createUserInput.Email);

      var response = _createUserService.Execute(user);

      return response;
    }
  }
}