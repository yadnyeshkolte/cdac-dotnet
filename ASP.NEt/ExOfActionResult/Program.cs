namespace ExOfActionResult
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            app.MapControllers();
            app.UseStaticFiles();
            app.UseRouting();
            

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
