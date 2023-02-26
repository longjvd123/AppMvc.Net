using APP.Services;
using Microsoft.AspNetCore.Mvc.Razor;

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
            services.Configure<RazorViewEngineOptions>(options => {
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
            app.UseRouting();

            app.UseAuthentication(); // xác định danh tính 
            app.UseAuthorization(); // xác thực quyền truy cập

            app.UseEndpoints(endpoint =>
            {
                endpoint.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );

                endpoint.MapRazorPages();

            });
        }
    }
}