using ExOfCustomMiddleware.CustomMiddleware;
namespace ExOfCustomMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<MyCustomMiddleware>();


            var app = builder.Build();

            app.Use(async (HttpContext context, RequestDelegate next) =>
            {
                await context.Response.WriteAsync("This is main class middleware \n");
                await next(context);
            });

            app.UseMyCustomMiddlewareExtMethod();


            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("This is run middleware \n");
            });



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
