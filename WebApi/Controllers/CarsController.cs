using Domain.Contracts.Services.CarServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.CreateCar;

namespace WebApi.Controllers {
  [Route("/api/[controller]")]
  [ApiController]

  public class CarsController : ControllerBase {
    private readonly ICreateCarService _createCarService;

    public CarsController(ICreateCarService createCarService){
      _createCarService = createCarService;
    }

    [HttpPost]
    public Task<IActionResult> Create([FromBody] CreateCarInput createCarInput){
      var car = new Car(Guid.NewGuid(), createCarInput.Model, createCarInput.Brand, createCarInput.UserId);
      var response = _createCarService.Create(car);
      return response;
    }
  }
}