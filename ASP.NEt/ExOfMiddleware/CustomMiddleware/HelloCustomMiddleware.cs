namespace ExOfMiddleware.CustomMiddleware
{
    
    public class HelloCustomMiddleware
    {

        private readonly RequestDelegate _next;

        public HelloCustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext) {

            if (httpContext.Request.Query.ContainsKey("FirstName") &&
                httpContext.Request.Query.ContainsKey("LastName")) {
                string fullname = httpContext.Request.Query["FirstName"] + " " +
                    httpContext.Request.Query["LastName"];

                await httpContext.Response.WriteAsync(fullname+"\n");
                await httpContext.Response.WriteAsync("Middleware 2 \n");
            }

            await _next(httpContext);
        }
    }
    //Extention method so that it can be added in the middleware pipeline easily

    public static class HelloCustomMiddleExtention
    {
        public static IApplicationBuilder UseHelloCustomMiddleware(this IApplicationBuilder builder) {
            return builder.UseMiddleware<HelloCustomMiddleware>();
        }
    }
}
