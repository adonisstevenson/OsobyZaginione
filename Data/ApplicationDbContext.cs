using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OsobyZaginione.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BK97AM5\SQLEXPRESS;Initial Catalog=OsobyZaginione;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Basic", ConcurrencyStamp = "2", NormalizedName = "User" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new Microsoft.AspNetCore.Identity.IdentityUserRole<string>() { RoleId = "fab4fac1-c546-41de-aebc-a14da6895711", UserId = "0d781ae7-f248-49c1-85b2-9aedf55ddde7" }
                );
        }
    }
}