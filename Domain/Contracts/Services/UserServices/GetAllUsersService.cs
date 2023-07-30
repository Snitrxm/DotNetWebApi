using Microsoft.AspNetCore.Mvc;

namespace Domain.Contracts.Services.UserServices {
  public interface IGetAllUsersService {
    Task<IActionResult> Execute();
  }
}