var builder = WebApplication.CreateBuilder(args); // configures builder
var app = builder.Build();

// Endpoints are defined directly on the 'app' object


// Request method of GET
app.MapGet("/", async (HttpContext context) =>
{
    context.Response.Headers["myKey"] = "myValue"; // add Http Header Values
    context.Response.Headers["myServer"] = "my Kestrel Server";
    await context.Response.WriteAsync("First Udemy Course");

});

// Map executes for any REST
app.Map("map1", async (context) =>
{
    await context.Response.WriteAsync("In Map 1");
});
app.Map("map2", async (context) =>
{
    await context.Response.WriteAsync("In Map 2");
});

// Place at the end of the middleware (terminal middleware)
app.MapFallback(async (context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});


app.Run();