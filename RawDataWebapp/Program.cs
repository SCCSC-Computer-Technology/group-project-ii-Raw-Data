using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RawDataWebapp;
using RawDataWebapp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the DI container.
builder.Services.AddRazorPages();

// Register custom services for sports database and user management.
builder.Services.AddScoped<SportsDbClient>();
builder.Services.AddSingleton<UserService>();

// Configure Entity Framework and connection to SQL Server.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext")));

// Configure authentication using cookie middleware.
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login"; // Redirect to Login page if not authenticated
        options.AccessDeniedPath = "/AccessDenied"; // Redirect here if access is denied
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30); // Cookie expiration time
    });

// Configure session state with a distributed memory cache.
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20); // Session timeout settings
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); // Use custom error handling in production
    app.UseHsts(); // Enforce strict transport security
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession(); // Enable session middleware.
app.UseAuthentication();
app.UseAuthorization();

// Map Razor Pages.
app.MapRazorPages();

app.Run();
