using Microsoft.Extensions.Options;
using RoutingExample.CustomConstraints;

var builder = WebApplication.CreateBuilder(args); // configures builder

// register custom routing constraint
builder.Services.AddRouting(options => {
    options.ConstraintMap.Add("months", typeof(MonthsCustomConstraint))
});

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
app.Map("files/{filename=image}.{extension=jpg}", async (context) =>
{
    string? filename = Convert.ToString(context.Request.RouteValues["filename"]); // access route paramater. Convert obj -> any type.
    string? extension = Convert.ToString(context.Request.RouteValues["Extension"]); // route parameter names are case insensitive
    await context.Response.WriteAsync($"in files {filename}.{extension}");
});

// Route parameter constraint applied here (as int)
app.Map("product/{id:int?}", async (context) =>
{
    int? prodId = Convert.ToInt32(context.Request.RouteValues["id"]); // Converts the value object to an integer
    await context.Response.WriteAsync($"In Product {prodId}");
});

// Custom Restraint Name
app.Map("sales-reports/{month:months}", async (context) =>
{
    string? month = Convert.ToString(context.Request.RouteValues["month"]); // Converts the value object to an integer
    await context.Response.WriteAsync($"In Product {month}");
});

// Place at the end of the middleware (terminal middleware)
app.MapFallback(async (context) =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});


app.Run();