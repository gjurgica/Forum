using Forum.DataAccess;
using Forum.DataAccess.Interfaces;
using Forum.DataAccess.Repositories;
using Forum.DomainClasses.Models;
using Forum.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.Helpers
{
    public class DiModule
    {
        public static IServiceCollection RegisterModules(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ForumDbContext>(ob => ob.UseSqlServer(
                connectionString
            ));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 7;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
            })
            .AddRoleManager<RoleManager<IdentityRole>>()
            .AddEntityFrameworkStores<ForumDbContext>()
            .AddDefaultTokenProviders();

            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Category>, CategoryRepository>();
            services.AddTransient<IRepository<Thread>, ThreadRepository>();
            services.AddTransient<IRepository<Post>, PostRepository>();
            services.AddTransient<IRepository<PrivateMessage>, PrivateMessageRepository>();
            services.AddTransient<IRepository<Alert>, AlertRepository>();

            //services.AddIdentity<User, IdentityRole>(options =>
            //{
            //    options.Password.RequireDigit = true;
            //    options.Password.RequiredLength = 7;
            //    options.Password.RequireLowercase = true;
            //    options.Password.RequireNonAlphanumeric = true;
            //    options.Password.RequireUppercase = true;
            //});

            services.Configure<IdentityOptions>(options =>
            {
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(01);
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Users/LogIn";
                options.AccessDeniedPath = "/Users/LogIn";
                options.SlidingExpiration = true;
            });

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IThreadService, ThreadService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPrivateMessageService, PrivateMessageService>();
            services.AddTransient<IAlertService, AlertService>();

            return services;
        }
    }
}
