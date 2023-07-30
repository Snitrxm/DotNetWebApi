using Domain.Entities;

namespace Domain.Contracts.Repositories {
  public interface ICarsRepository {
    Task Create(Car car);
  }
}