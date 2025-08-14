using Entities;
using InterfaceRepos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace RepoEF6
{
    public static class ExtensionServiceCollection
    {
        public static IServiceCollection AddRepoEF6(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }

    public class UserRepository : IUserRepository
    {
        //private readonly AppDbContext dbContext;

        //public UserRepository(AppDbContext dbContext)
        //{
        //    this.dbContext = dbContext;
        //    // Initialisation si nécessaire
        //}

        public List<User> GetAll()
        {
            //var users = this.dbContext.Users.ToList(); // pour simuler la récupération des données

            return new List<User>
            {
                new User { Name = "Alice", Email = "etesr", IdGroup = 1 },
                new User { Name = "Bob", Email = "fddsfsdfsdffds", IdGroup = 1 },
                new User { Name = "Vincent", Email = "ddddd", IdGroup = 2 },
            };
        }
    }
}
