using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ChatTogether.Domain.Model;

namespace ChatTogether.Infrastructure
{
    public class Context : IdentityDbContext
    {
  
        public DbSet<User> AppUsers { get; set; }
        public DbSet<UserRole> AppUserRoles { get; set; }
        public DbSet<Role> AppRoles { get; set; }
        public DbSet<Acquaintance> Acquaintances { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Confirmation> Confirmations { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }


        // Fluent API gdy będzie potrzeba definiowania relacji jeden do jednego lub wiele do wielu
        //Przykład jeden do jednego
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);

        //    builder.Entity<User>()
        //        .HasOne(a => a.UserContact).WithOne(b => b.User)
        //        .HasForeignKey<UserContact>(e => e.UserRef);
        //}
    }
}
