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

            //DI Resolvers � tan�mlad�k ve Connection String i�in Configuration propertsini g�nderdik
            services.AddCustomDependencies(Configuration);

            //Auth Cookie Ekledik
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt=> 
            {
                opt.Cookie.HttpOnly = true;//Cookie eri�imine taray�c� �zerinden eri�ilemesin diye bu �ekilde tan�mlad�k
                opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Auth/Login");//Giri� yap�lmam�� ise logine y�nlendiriyoruz
                opt.Cookie.Name = "DapperCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;//Cookie kullan�m� di�er web sayfalar� i�in kapal�
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;//HTTP ya da HTTPS ler kendi aras�nda ileti�im kurar
                opt.ExpireTimeSpan = TimeSpan.FromDays(10); //Cookie ya�am s�resi
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

            app.UseAuthentication(); //�yelik Sistemi
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
