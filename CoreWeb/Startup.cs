using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CoreWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
//using Microsoft.CodeAnalysis.Options;
//using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
//using Westwind.AspNetCore.LiveReload;

namespace CoreWeb
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
            services.AddControllersWithViews();
            services.AddMvc();

            //runtime���q�A�i�H�ק�razor page
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvc().AddRazorRuntimeCompilation();

            string connStr = Configuration.GetConnectionString("MvcMovieContext");
            services.AddDbContext<MvcMovieContext>(Option => Option.UseSqlServer(connStr));

            double LoginExpireMinute = Configuration.GetValue<double>("LoginExpireMinute");
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
                option => {
                    //option.Cookie.HttpOnly = true; //�s�����|����cookie�u��g��HTTP(S)��w�Ӧs��
                    option.LoginPath = new PathString(Configuration.GetValue<string>("LoginPath"));
                    option.LogoutPath = new PathString(Configuration.GetValue<string>("LogoutPath"));
                    option.ExpireTimeSpan = TimeSpan.FromMinutes(LoginExpireMinute);
                });
            //services.AddDbContext<MvcMovieContext>(optionsBuilder =>
            //{
            //    optionsBuilder.UseSqlServer(connStr);
            //});
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            //app.UseCookiePolicy(); //�ҥ�cookie��h�\��
            app.UseAuthentication(); //�ҥΨ����ѧO
            app.UseAuthorization();//�ҥα��v�\��AController�BAction�~��[�W [Authorize] �ݩ�

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
