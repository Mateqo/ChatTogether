using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatTogether.Infrastructure
{
    public class Context : IdentityDbContext
    {
        //Tutaj definiujemy tabele

        //Przykład
        //public DbSet<User> Users { get; set; }


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
