using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class TrainingDbContext : DbContext
    {
        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {

        }
        public DbSet<State> States { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}
