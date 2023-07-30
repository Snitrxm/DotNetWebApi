using Domain.Contracts.Services.UserServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.CreateUser;

namespace WebApi.Controllers {
  [Route("/api/[controller]")]
  [ApiController]

  public class UsersController : ControllerBase {
    private readonly ICreateUserService _createUserService;

    public UsersController(ICreateUserService createUserService){
      _createUserService = createUserService;
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateUserInput createUserInput){
      var user = new User(Guid.NewGuid(), createUserInput.Name, createUserInput.Email);

      _createUserService.Execute(user);

      return Created("", user);
    }
  }
}