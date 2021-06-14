using ChatTogether.Application;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Data;
using ChatTogether.Infrastructure;
using FluentAssertions.Common;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatTogether
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
            services.AddDbContext<Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), b=>b.MigrationsAssembly("ChatTogether.Web")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDistributedMemoryCache();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews().AddFluentValidation(fv => fv.RunDefaultMvcValidationAfterFluentValidationExecutes = false); 
            services.AddRazorPages();
            services.AddSignalR();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            //DependencyInjection services
            services.AddAplication();
            services.AddInfrastructure();

            //Fluent Validation
            services.AddTransient<IValidator<UserLogin>, UserLoginValidator>();
            services.AddTransient<IValidator<UserRegister>, UserRegisterValidator>();
            services.AddTransient<IValidator<UserEditProfile>, UserEditProfileValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }           

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapHub<Chat>("/chatHub");
            });
        }
    }
}
