using ForumDataAccess;
using ForumDataAccess.Interfaces;
using ForumDataAccess.Repositories;
using ForumDomain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumServices.Helpers
{
    public class DiModule
    {
        public static IServiceCollection RegisterModules(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Thread>, ThreadRepository>();
            services.AddTransient<IPostRepository<Post>, PostRepository>();
            services.AddTransient<IRepository<PostReply>, PostReplyRepository>();
            services.AddTransient<IRepository<Category>, CategoryRepository>();
            services.AddDbContext<ForumDbContext>(ob => ob.UseSqlServer(
                connectionString
            ));

            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequireNonAlphanumeric = true;
            })
          .AddRoleManager<RoleManager<IdentityRole>>()
          .AddEntityFrameworkStores<ForumDbContext>()
          .AddDefaultTokenProviders();

            return services;
        }
    }
}
