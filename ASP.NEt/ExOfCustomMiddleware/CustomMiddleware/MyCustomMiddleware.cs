using System.Runtime.CompilerServices;

namespace ExOfCustomMiddleware.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next) {
            await context.Response.WriteAsync("My custom middleware start \n");
            await next(context);
            await context.Response.WriteAsync("My custom middleware end \n");


            // throw new NotImplementedException();
        }

    }

    //Extenstion method for easy registration
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {

            return app.UseMiddleware<MyCustomMiddleware>();
        }
    }

}
