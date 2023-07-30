using Domain.Contracts.Repositories;
using Domain.Contracts.Services.CarServices;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services.Car {
  public class CreateCarService : ICreateCarService
  {
    private readonly ICarsRepository _carsRepository;
    private readonly IUsersRepository _usersRepository;

    public CreateCarService(ICarsRepository carsRepository, IUsersRepository usersRepository){
      _carsRepository = carsRepository;
      _usersRepository = usersRepository;
    }

    public async Task<IActionResult> Create(Domain.Entities.Car car)
    {
      var user = await _usersRepository.FindById(car.UserId);
      Console.WriteLine(user);

      if(user == null){
        return new BadRequestObjectResult("User does not exist.");
      }

      await _carsRepository.Create(car);
    
      return new OkObjectResult(car);
    }
  }
}