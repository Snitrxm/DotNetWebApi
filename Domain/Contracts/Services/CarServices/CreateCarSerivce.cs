using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Domain.Contracts.Services.CarServices {
  public interface ICreateCarService {
    Task<IActionResult> Create(Car car);
  }
}