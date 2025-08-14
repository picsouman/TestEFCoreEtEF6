using InterfaceRepos;
using Microsoft.Extensions.DependencyInjection;

namespace RepoEFCore
{
    public static class ExtensionServiceCollection
    {
        public static IServiceCollection AddRepoEFCore(this IServiceCollection services)
        {
            services.AddScoped<IGroupRepository, GroupRepository>();
            return services;
        }
    }

    public class GroupRepository : IGroupRepository
    {
        public List<Entities.Group> GetAll()
        {
            return new List<Entities.Group>
            {
                new Entities.Group { Id = 1, Name = "Group1" },
                new Entities.Group { Id = 2, Name = "Group2" },
            };
        }
    }
}
