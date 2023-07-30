using DataAccess.ApiDbContext;
using Domain.Contracts.Repositories;
using Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories {
  public class UsersRepository : IUsersRepository
  {
    private readonly ApiDbContextPostgres _apiDbContext;

    public UsersRepository(ApiDbContextPostgres apiDbContext){
      _apiDbContext = apiDbContext;
    }

    public async Task Create(User user)
    {
      await _apiDbContext.Users.AddAsync(user);
      await _apiDbContext.SaveChangesAsync();
    }

    public async Task<List<User>> FindAll()
    {
      var users = await _apiDbContext.Users.Include(u => u.Cars).ToListAsync();
      return users;
    }

    public User? FindByEmail(string email)
    {
      var user = _apiDbContext.Users.Where(u => u.Email == email).FirstOrDefault();
      return user;
    }

    public async Task<User>? FindById(Guid id)
    {
      var user = await _apiDbContext.Users.Where(u => u.Id == id).Include(u => u.Cars).FirstOrDefaultAsync();
      return user;
    }
  }
}