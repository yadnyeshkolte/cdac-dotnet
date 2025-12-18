# Middleware

At its core, middleware in ASP.NET Core is a series of components that form a pipeline through which every HTTP request and response flows. Each middleware component can:

1. Examine the incoming request.
2. Modify the request or response (if needed).
3. Invoke the next middleware in the pipeline or short-circuit the process and generate a response itself.

This pipeline allows you to modularize your application's logic and add features like authentication, logging, error handling, routing, and more in a clean and maintainable way.

## Middleware Chain (Request Pipeline)

Imagine the request pipeline as a series of connected pipes. Each piece of middleware is like a valve in this pipeline, allowing you to control the flow of information and apply specific operations at different stages. The order you register your middleware matters, as they are executed sequentially.

## app.Use vs. app.Run

These two methods are fundamental for adding middleware to your pipeline, but they have key differences:

### app.Use(async (context, next) => { ... })

- **Non-Terminal Middleware**: This type of middleware typically performs some action and then calls the next delegate to pass control to the next middleware in the pipeline.
- **Can Modify Request/Response**: It can change the request or response before passing it along.
- **Examples**: Authentication, logging, custom headers, etc.

### app.Run(async (context) => { ... })

- **Terminal Middleware**: This middleware doesn't call next; it ends the pipeline and generates the response itself.
- **Often Used for the Final Response**: It's commonly used for handling requests that don't need further processing (e.g., returning a simple message).
- **Can't Modify Request**: Since it's the end of the line, it cannot modify the request before passing it on.

### Syntax:

```csharp
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("");
});

app.Use(async (HttpContext context) => {
    await context.Response.WriteAsync("");
});
```

## Key Points

- **Middleware Order is Crucial**: The order in which you register middleware matters, as they are executed in sequence.
- **Use app.Use for Non-Terminal Actions**: Use it for tasks like authentication, logging, or modifying headers/bodies.
- **Use app.Run to Terminate the Pipeline**: Employ it when you want to generate the final response.
- **Short-Circuiting**: Middleware can choose to short-circuit the pipeline (not call next) and return a response early if needed.

## Custom Middleware in ASP.NET Core

While ASP.NET Core provides a plethora of built-in middleware components, sometimes you need to create your own to address specific requirements unique to your application. Custom middleware allows you to:

- **Encapsulate logic**: Bundle related operations (e.g., logging, security checks, custom headers) into a reusable component.
- **Customize behavior**: Tailor the request/response pipeline to precisely match your application's needs.
- **Improve code organization**: Keep your middleware code clean and maintainable.

### Anatomy of a Custom Middleware Class

1. **Implement IMiddleware**: This interface requires a single method: `InvokeAsync(HttpContext context, RequestDelegate next)`. This is the heart of your middleware's logic.
2. **InvokeAsync or Invoke Method**:
   - **context**: The HttpContext provides access to the request and response objects.
   - **next**: The RequestDelegate allows you to call the next middleware in the pipeline

## Custom Conventional Middleware

ASP.NET Core middleware comes in two flavors: conventional and factory-based. Conventional middleware, as shown in your example, is a simple yet powerful way to encapsulate custom logic for processing HTTP requests and responses.

### Characteristics

- **Class-Based**: Conventional middleware is implemented as a class.
- **Constructor Injection**: It receives dependencies (if any) through its constructor.
- **Invoke Method**: This is the heart of the middleware, containing the logic that handles each request.
- **RequestDelegate**: The Invoke method takes a RequestDelegate parameter (_next in your example). This delegate represents the next middleware in the pipeline.
- **Flexibility**: You have full control over the request and response objects within the Invoke method

**UseHelloCustomMiddleware Extension**: This extension method simplifies the registration process by hiding the details of instantiating and using your custom middleware class

1. When a request arrives, ASP.NET Core traverses the middleware pipeline.
2. It reaches HelloCustomMiddleware, which checks for the specific query parameters.
3. If the parameters are present, the middleware generates a personalized greeting.
4. Regardless of whether it generates the greeting, the middleware calls `next(context)` to pass the request along to the next middleware component in the pipeline.

### Key Points

- **Simplicity**: Conventional middleware is easy to write and understand.
- **Control**: You have fine-grained control over how the request is processed and how the response is generated.
- **Extension Methods**: Use extension methods to make middleware registration clean and readable.

## UseWhen()

`UseWhen()` is a powerful extension method in ASP.NET Core's IApplicationBuilder interface. It allows you to conditionally add middleware to your request pipeline based on a predicate (a condition). This means you can create dynamic pipelines where specific middleware components are executed only when certain conditions are met.

### Syntax

```csharp
app.UseWhen(
    context => /* Your condition here */,
    app => /* Middleware configuration for the branch */
);
```

### Key Points:

1. **Predicate Evaluation**: When a request comes in, the `UseWhen()` method first evaluates the predicate function against the HttpContext.
2. **Branching (if true)**: If the predicate returns true, the middleware branch specified in the configuration action is executed. The request flows through this branch, potentially undergoing modifications or generating a response.
3. **Rejoining the Main Pipeline**: After the branch is executed (or skipped if the predicate was false), the request flow rejoins the main pipeline, continuing with the next middleware components registered after the `UseWhen()` call.
