using Entities;
using System.Data.Entity;

namespace RepoEF6
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuration de User
            modelBuilder.Entity<User>().HasKey(u => new { u.Name, u.Email });
            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<User>().Property(u => u.IdGroup).IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }

    public class AppDbInitializer : CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Users.Add(new User { Name = "Admin", Email = "admin@test.com", IdGroup = 1 });
            context.Users.Add(new User { Name = "John", Email = "john@test.com", IdGroup = 1 });
            context.Users.Add(new User { Name = "Vincent", Email = "vincent@test.com", IdGroup = 2 });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
