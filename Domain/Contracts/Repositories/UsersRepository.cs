using Domain.Entities;

namespace Domain.Contracts.Repositories {
  public interface IUsersRepository {
    Task Create(User user);
    User? FindByEmail(string email);
    User? FindById(Guid id);
    Task<List<User>> FindAll();
  }
}