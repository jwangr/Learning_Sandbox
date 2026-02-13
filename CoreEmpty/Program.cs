var builder = WebApplication.CreateBuilder(args); // configures builder
var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
    context.Response.Headers["myKey"] = "myValue"; // add Http Header Values
    context.Response.Headers["myServer"] = "my Kestrel Server";
    await context.Response.WriteAsync("Hello "); // Writes into body
    await context.Response.WriteAsync("First Udemy Course");

});

app.Run(); // starts the server (default application server = Kestrel, returns information to the client's browser) with 'dotnet run'