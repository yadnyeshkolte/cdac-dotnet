namespace ExOfUseWhen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();



            app.UseWhen(
                context => context.Request.Query.ContainsKey("username"),
                app => 
                {
                    app.Use(async (HttpContext context, RequestDelegate next) =>
                    {
                        await context.Response.WriteAsync("Username is "+ 
                            context.Request.Query["username"]);
                    });
                }
             );
            /*
            https://localhost:7069/?username=Yadnyesh
            Username is Yadnyesh
            */

            /*  
                {
                    "username": "Yadnyesh"
                }
             
                https://localhost:7069/
             
             */















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
