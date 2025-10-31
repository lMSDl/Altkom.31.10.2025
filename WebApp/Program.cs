var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<WebApp.Services.UserService>();

// Add cookie support
builder.Services.AddAuthentication("Cookies").AddCookie();

var app = builder.Build();

// Use authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Use routing and map controllers
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
