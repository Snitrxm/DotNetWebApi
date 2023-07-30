using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ApiDbContext
{
    public class ApiDbContextPostgres : DbContext
    {
        public ApiDbContextPostgres(DbContextOptions<ApiDbContextPostgres> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}