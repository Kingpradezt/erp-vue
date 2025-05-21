using Microsoft.EntityFrameworkCore;
using ERP.Inventory.API.Data;   // Your Data namespace
using ERP.Inventory.API.Services; // Your Services namespace (BaseService)

var builder = WebApplication.CreateBuilder(args);

// Add CORS policy to allow your Vue.js app on localhost:8080

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVueApp", policy =>
    {
        policy.WithOrigins("http://localhost:8080")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add controller services
builder.Services.AddControllers();
builder.Services.AddScoped<BaseService>();

// Add OpenAPI (Swagger)
//builder.Services.AddOpenApi();

// Register your AppDbContext with MariaDB connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(10, 4, 24)) // Update to your MariaDB version
    ));

// Register your BaseService for dependency injection

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  //  app.MapOpenApi();
}

//app.UseHttpsRedirection();

app.UseCors("AllowVueApp");

// Map controllers
app.MapControllers();

app.Run();
