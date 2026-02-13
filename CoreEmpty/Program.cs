var builder = WebApplication.CreateBuilder(args); // configures builder

// service class = reusable class
//  in ASP core, controllers are services that need to be added
// builder.Services.AddTransient<HomeController>()
builder.Services.AddControllers(); // adds controllers classes services in bulk, instead of above

var app = builder.Build();

// MapControllers detects and calls all controller classes. For all action methods, routing will be added.
app.MapControllers();

app.Run();