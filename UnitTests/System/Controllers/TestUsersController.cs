using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;
using WebApi.Models.CreateUser;
using Xunit;
using Moq;
using Domain.Contracts.Services.UserServices;
using FluentAssertions;
using System.Diagnostics;

namespace UnitTest.Controllers { 
  public class TestUsersController {
    private readonly Mock<ICreateUserService> _mockCreateUserService;
    private readonly Mock<IGetAllUsersService> _mockGetAllUsersService;
    private readonly Mock<IGetUserService> _mockGetUserService;

    public TestUsersController()
    {
        _mockCreateUserService = new Mock<ICreateUserService>();
        _mockGetAllUsersService = new Mock<IGetAllUsersService>();
        _mockGetUserService = new Mock<IGetUserService>();
    }

    [Fact]
    public async Task CreateUser_OnSuccess_ReturnsStatusCode200(){
      var usersController = new UsersController(
        _mockCreateUserService.Object,
        _mockGetAllUsersService.Object,
        _mockGetUserService.Object
      );

      var createUserInput = new CreateUserInput {
        Email = "test@email",
        Name = "TestName"
      };

      Debug.WriteLine(createUserInput);

      var result = (OkObjectResult)await usersController.Create(createUserInput);

      Debug.WriteLine(result);

    }
  }
}