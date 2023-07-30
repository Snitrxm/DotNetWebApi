using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ApiDbContext
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}