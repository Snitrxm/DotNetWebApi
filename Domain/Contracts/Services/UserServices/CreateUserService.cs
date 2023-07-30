using Domain.Entities;

namespace Domain.Contracts.Services.UserServices {
  public interface ICreateUserService {
    void Execute(User user);
  }
}