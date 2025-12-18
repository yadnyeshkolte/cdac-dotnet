# Routing

Routing is the mechanism that ASP.NET Core uses to match incoming HTTP requests to specific endpoints (e.g., controller actions, Razor Pages, or minimal API handlers) within your application. This allows you to define clean and meaningful URLs that clearly indicate the resources or actions being requested.

## Routing Execution Flow

1. **Endpoint Registration**: You define endpoints (routes) within your application, specifying:
   - The URL pattern (e.g., `/products`, `/api/orders/{id}`)
   - The HTTP method(s) the endpoint handles (GET, POST, etc.)
   - The code to execute when the endpoint is matched (RequestDelegate)

2. **Request Matching (Middleware)**:
   - The `UseRouting` middleware component is added to the pipeline
   - When a request arrives, `UseRouting` analyzes the incoming URL and HTTP method
   - It compares the URL against your registered endpoints to find the best match

3. **Endpoint Execution (Middleware)**:
   - The `UseEndpoints` middleware component is added to the pipeline, following `UseRouting`
   - If `UseRouting` found a matching endpoint, `UseEndpoints` executes the code (the RequestDelegate) associated with that endpoint

## UseRouting vs. UseEndpoints

### UseRouting
- Responsible for route matching - finding the right endpoint for a given request
- Adds route data to the `HttpContext`, which subsequent middleware can use to make decisions
- Must come before `UseEndpoints`

### UseEndpoints
- Responsible for endpoint execution - invoking the code (the delegate) associated with the matched endpoint
- Lets you configure the endpoints (e.g., define policies, filters) using lambda expressions

## Map* Methods: Creating Endpoints

ASP.NET Core provides a family of `Map*` extension methods on the `IEndpointRouteBuilder` interface that simplify endpoint creation:

- **MapGet**: Creates an endpoint that only handles GET requests
- **MapPost**: Creates an endpoint that only handles POST requests
- **MapPut, MapDelete**: Create endpoints for PUT and DELETE requests, respectively
- **MapMethods**: Creates an endpoint that handles multiple HTTP methods
- **MapControllerRoute, MapAreaControllerRoute**: Used for configuring MVC/Razor Pages controllers
- **MapFallbackToFile**: Used to specify a default file to serve when no other endpoint matches

## GetEndpoint()

The `GetEndpoint()` method is a powerful tool for retrieving information about the specific endpoint that was selected to handle an incoming HTTP request. This method is an extension method available on the `HttpContext` object.

## Route Parameters

Route parameters are placeholders within your URL patterns that capture values from incoming requests. These values can then be used within your endpoint handlers to customize the response or perform specific actions.

### Types of Route Parameters

1. **Required Parameters**:
   - Example: `/products/{id}` (The `id` parameter is required)

2. **Optional Parameters**:
   - Example: `/products/details/{id?}` (The `id` parameter is optional)

3. **Parameters with Default Values**:
   - Example: `/employee/profile/{EmployeeName=Scott}` (The `EmployeeName` parameter defaults to "Scott")

## Route Constraints

Route constraints are an essential tool in ASP.NET Core routing that allows you to add extra validation to your route parameters. They define rules that restrict the values a parameter can accept, helping you filter out invalid requests before they reach your endpoint handlers.

### Why Use Route Constraints?

- **Enhanced Validation**: Ensure that only requests with valid parameter values are handled
- **Improved Security**: Prevent malicious input by rejecting requests with potentially harmful values
- **Cleaner Code**: Avoid cluttering your endpoint handlers with validation logic
- **Explicit Routing**: Make your routes more self-documenting and easier to understand

## Endpoint Selection

When a request arrives at your ASP.NET Core application, the routing middleware (`UseRouting`) analyzes the URL and HTTP method. It then compares this information against the collection of endpoints you've defined using methods like `MapGet`, `MapPost`, etc. The goal is to find the most suitable endpoint to handle the request.
