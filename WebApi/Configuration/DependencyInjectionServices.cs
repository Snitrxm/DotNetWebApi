using Application.Services.Car;
using Application.Services.User;
using Domain.Contracts.Services.UserServices;
using Domain.Contracts.Services.CarServices;

namespace WebApi.Configuration {
  public static class DependencyInjectionServices {
    public static void RegisterServices(this IServiceCollection services){
      services.AddScoped<ICreateUserService, CreateUserService>();
      services.AddScoped<ICreateCarService, CreateCarService>();
      services.AddScoped<IGetAllUsersService, GetAllUsersService>();
    } 
  }
}