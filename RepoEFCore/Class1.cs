using InterfaceRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RepoEFCore
{
    public static class ExtensionServiceCollection
    {
        public static IServiceCollection AddRepoEFCore(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"DataSource=local.db", sqliteOptions =>
                {
                    sqliteOptions.CommandTimeout(30);
                }), ServiceLifetime.Scoped);

            services.AddScoped<IGroupRepository, GroupRepository>();
            return services;
        }
    }

    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext dbContext;

        public GroupRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Entities.Group> GetAll()
        {
            //var groups = this.dbContext.Groups.ToList(); // pour simuler la récupération des données

            return new List<Entities.Group>
            {
                new Entities.Group { Id = 1, Name = "Group1" },
                new Entities.Group { Id = 2, Name = "Group2" },
            };
        }
    }
}
