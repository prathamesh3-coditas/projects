using API_Apps_2_new.models;
using API_Apps_2_new.models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<NorthwindContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

builder.Services.AddScoped<IDbAccess<Customer, int>, CustomerDataAccess>();
builder.Services.AddScoped<IDbAccess<Product, int>, ProductDataAccess>();
builder.Services.AddScoped<IDbAccess<Order, int>, OrderDataAccess>();
builder.Services.AddScoped<IDbAccess<OrderDetail, int>, OrderDetailsDataAccess>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
