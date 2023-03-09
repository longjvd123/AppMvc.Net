using System.Net;
using App.ExtendMethods;
using APP.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing.Constraints;

namespace APP
{
    public class Startup
    {
        public static string ContentRootPath { get; set; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            configuration = configuration;
            ContentRootPath = env.ContentRootPath;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddTransient(typeof(ILogger<>), typeof(Logger<>));
            services.Configure<RazorViewEngineOptions>(options =>
            {
                // /View/Controller/Action.cshtml
                // /MyView/Controller/Action.cshtml

                // {0} -> tên Action
                // {1} -> ten controller
                // {2} -> ten Area
                options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
            });

            // services.AddSingleton<ProductService>();
            // services.AddSingleton<ProductService, ProductService>();
            // services.AddSingleton(typeof(ProductService));
            services.AddSingleton(typeof(ProductService), typeof(ProductService));
            services.AddSingleton<PlanetServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.AddStatusCodePage(); // tuy bien response khi co loi
            app.UseRouting();

            app.UseAuthentication(); // xác định danh tính 
            app.UseAuthorization(); // xác thực quyền truy cập

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapGet("/sayhi", async (context) =>
                {
                    await context.Response.WriteAsync($"Hello ASP.NET MVC {DateTime.Now}");
                });

                endpoint.MapControllerRoute(
                    name:"First",
                    pattern: "{url:regex(^((xemsanpham)|(viewproduct))$)}/{id:range(2,4)}",
                    defaults: new{
                        controller = "First",
                        action = "ViewProduct"
                    }
                );


                endpoint.MapControllerRoute(
                    name: "default",
                    pattern: "/{controller=Home}/{action=Index}/{id?}"
                );

                endpoint.MapAreaControllerRoute(
                    name: "product",
                    pattern: "/{controller=Product}/{action=Index}/{id?}",
                    areaName: "ProductManage"
                );
                endpoint.MapRazorPages();
            });
        }
    }
}
// dotnet aspnet-codegenerator controller -name LearnAsp -outDir Controllers
// dotnet aspnet-codegenerator view Index Empty -outDir Views/LearnAsp -l _Layout -f
// dotnet aspnet-codegenerator area Product
