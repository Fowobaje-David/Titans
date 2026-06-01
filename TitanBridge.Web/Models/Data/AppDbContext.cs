using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TitanBridge.Web.Models;

namespace TitanBridge.Web.Models.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Payment>  Payments { get; set; }
        public DbSet<FeeStructure> FeeStructures { get; set; } 

        



    }
}
