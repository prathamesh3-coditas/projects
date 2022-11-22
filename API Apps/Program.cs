using API_Apps.Custom_Middleware;
using API_Apps.models;
using API_Apps.models.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Register eShoppingCodiContext in DI container
//Provide connection string for sql server

builder.Services.AddDbContext<eShoppingCodiContext>(options =>
{
    //Pass connection string
    //using builder.Configuration.GetConnectionString()
    //this will read connection string from appsettings.json
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});


//Register custom service classes in DI container
builder.Services.AddScoped<IDbAccessService<Catagory, int>, CatagoryDataAccess>();
builder.Services.AddScoped<IDbAccessService<Product, int>, ProductDataAccess>();

//register HTTP pipeline fro API controllers
//This will look for API controllers instance and execute it
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(20);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseSession();

app.UseAuthorization();

app.UseAppExceptionHandeller();

app.MapControllers();

app.Run();
