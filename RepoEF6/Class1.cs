using Entities;
using InterfaceRepos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace RepoEF6
{
    public static class ExtensionServiceCollection
    {
        public static IServiceCollection AddRepoEF6(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }

    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            return new List<User>
            {
                new User { Name = "Alice", Email = "etesr", IdGroup = 1 },
                new User { Name = "Bob", Email = "fddsfsdfsdffds", IdGroup = 1 },
                new User { Name = "Vincent", Email = "ddddd", IdGroup = 2 },
            };
        }
    }
}
