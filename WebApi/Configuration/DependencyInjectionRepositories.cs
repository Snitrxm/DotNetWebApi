using DataAccess.Repositories;
using Domain.Contracts.Repositories;

namespace WebApi.Configuration {
  public static class DependencyInjectionRepositories {
    public static void RegisterRepositories(this IServiceCollection services){
      services.AddScoped<IUsersRepository, UsersRepository>();
      services.AddScoped<ICarsRepository, CarsRepository>();
    } 
  }
}