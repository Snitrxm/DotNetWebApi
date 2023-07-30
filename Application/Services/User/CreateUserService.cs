using DataAccess.ApiDbContext;
using Domain.Contracts.Services.UserServices;

namespace Application.Services.User {
  public class CreateUserService : ICreateUserService
  {
    private readonly ApiDbContext _apiDbContext;

    public CreateUserService(ApiDbContext apiDbContext){
      _apiDbContext = apiDbContext;
    }


    public async void Execute(Domain.Entities.User user)
    {
      await _apiDbContext.Users.AddAsync(user);
      await _apiDbContext.SaveChangesAsync();
    }
  }
}