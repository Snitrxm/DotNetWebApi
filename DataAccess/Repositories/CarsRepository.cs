using DataAccess.ApiDbContext;
using Domain.Contracts.Repositories;
using Domain.Entities;

namespace DataAccess.Repositories {
  public class CarsRepository : ICarsRepository
  {
    private readonly ApiDbContextPostgres _apiDbContext;

    public CarsRepository(ApiDbContextPostgres apiDbContext){
      _apiDbContext = apiDbContext;
    }

    public async Task Create(Car car)
    {
      await _apiDbContext.Cars.AddAsync(car);
      await _apiDbContext.SaveChangesAsync();
    }
  }
}