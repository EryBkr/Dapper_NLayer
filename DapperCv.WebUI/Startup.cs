using DapperCv.Business.IOC.Microsoft;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperCv.WebUI
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
            services.AddControllersWithViews().AddFluentValidation();

            //DI Resolvers ý tanýmladýk ve Connection String için Configuration propertsini gönderdik
            services.AddCustomDependencies(Configuration);

            //Auth Cookie Ekledik
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt=> 
            {
                opt.Cookie.HttpOnly = true;//Cookie eriþimine tarayýcý üzerinden eriþilemesin diye bu þekilde tanýmladýk
                opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Auth/Login");//Giriþ yapýlmamýþ ise logine yönlendiriyoruz
                opt.Cookie.Name = "DapperCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;//Cookie kullanýmý diðer web sayfalarý için kapalý
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;//HTTP ya da HTTPS ler kendi arasýnda iletiþim kurar
                opt.ExpireTimeSpan = TimeSpan.FromDays(10); //Cookie yaþam süresi
            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication(); //Üyelik Sistemi
            app.UseAuthorization(); //Yetkilendirme Sistemi

            app.UseEndpoints(endpoints =>
            {
                //Route for Area
                endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name:"default",pattern:"{controller=Home}/{action=Index}/{id?}");
               
            });
        }
    }
}
