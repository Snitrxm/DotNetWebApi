using Microsoft.AspNetCore.Mvc;

namespace Domain.Contracts.Services.UserServices {
  public interface IGetUserService {
    IActionResult Execute(Guid id);
  }
}