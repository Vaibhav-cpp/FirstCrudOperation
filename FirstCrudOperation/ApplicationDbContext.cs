using FirstCrudOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstCrudOperation
{
    public class ApplicationDbContext: DbContext //In hearting this class from EFCore
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }    
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}
