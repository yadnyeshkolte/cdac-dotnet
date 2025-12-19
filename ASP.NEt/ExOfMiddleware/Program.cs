using ExOfMiddleware.CustomMiddleware;

namespace ExOfMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            /*
            app.MapGet("/", () => "Hello World!");
            https://localhost:7076/  ->  Hello World! 
            */

            /*
            app.Run(async (HttpContext context) => {
                await context.Response.WriteAsync("Hello");
            });
            // it will not acceess this first run only as it is the first middleware in the pipeline
            // so the below middleware will never be reached (Short Circuit Process)
            app.Run(async (HttpContext context) => {
                await context.Response.WriteAsync("Hello Next World");
            });

            https://localhost:7076/  ->  Hello
            */


            /*
            app.Use(async(HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("Hello \n");
                await next(context);
            });


            app.Use(async(HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("Hello World \n");
                await next(context);
            });

            app.Run(async(HttpContext context) => {
                await context.Response.WriteAsync("Hello World It is \n");
            });

            /*  
            *  
            *  This will give error as the RUn is the terminal middleware and it does not have next parameter
            *  
            app.Run(async (HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("Hello World \n");
                await next(context);
            });
            
            https://localhost:7076/ 
                Hello
                Hello World
                Hello World It is
            */



            //Custom Middleware

            //middleware 1

            app.Use(async (HttpContext context, RequestDelegate next) => {
                await context.Response.WriteAsync("Middleware 1 \n");
                await next(context);
            });

            //middleware 2

            app.UseHelloCustomMiddleware();
            /*
             https://localhost:7076/?FirstName=Yadnyesh&LastName=Kolte
            Middleware 1 
            Yadnyesh Kolte
            Middleware 2 
            Middleware 3 
            */



            //middleware 3
            app.Run(async (HttpContext context) => {
                   await context.Response.WriteAsync("Middleware 3 \n");
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
