using AutoMapper;
using ForumDataAccess;
using ForumDataAccess.Interfaces;
using ForumDataAccess.Repositories;
using ForumDomain;
using ForumServices.Helpers;
using ForumServices.Interfaces;
using ForumServices.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ForumWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Forum>, ForumRepository>();
            services.AddTransient<IPostRepository<Post>, PostRepository>();
            services.AddTransient<IRepository<PostReply>, PostReplyRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IForumService, ForumService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IPostReplyService, PostReplyService>();

            services.AddDbContext<ForumDbContext>(ob => ob.UseSqlServer(
                Configuration.GetConnectionString("ForumDbConnection")
            ));

            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequireNonAlphanumeric = true;
            })
           .AddRoleManager<RoleManager<IdentityRole>>()
           .AddEntityFrameworkStores<ForumDbContext>()
           .AddDefaultTokenProviders();


            services.AddAutoMapper(opts =>
            {
                opts.AddProfile<MapProfile>();
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
