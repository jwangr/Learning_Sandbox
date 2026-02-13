var builder = WebApplication.CreateBuilder(args); // configures builder
var app = builder.Build();

// Middleware runs in chronological order
// Request Delegate enables it to run to the next middleware
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello ");
    await next(context); // call the next middleware with this "context"
});

app.MapGet("/", async (HttpContext context) =>
{
    context.Response.Headers["myKey"] = "myValue"; // add Http Header Values
    context.Response.Headers["myServer"] = "my Kestrel Server";
    await context.Response.WriteAsync("First Udemy Course");

});

app.Run();