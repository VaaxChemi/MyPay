using MyPay.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MyPay.API.DATA
{
    public class MyPayDbContext : DbContext
    {
        public MyPayDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<User> Activity { get; set; }
        
    }
}


