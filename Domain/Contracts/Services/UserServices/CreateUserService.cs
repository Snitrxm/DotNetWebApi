using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Contracts.Services.UserServices {
  public interface ICreateUserService {
    Task<IActionResult> Execute(User user);
  }
}