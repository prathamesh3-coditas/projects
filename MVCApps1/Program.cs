using Coditas_MVCApps1_DataAccess;
using Coditas_MVCApps1_Repository;
using Coditas_MVCApps1_DataAccess.models;
using Microsoft.EntityFrameworkCore;
using MVCApps1.Custom_Filters;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddDbContext<eShoppingCodiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});


builder.Services.AddScoped<IDbRepository<Catagory,int>,CatagoryRepository>();
builder.Services.AddScoped<IDbRepository<Product,int>,ProductRepository>();


builder.Services.AddControllersWithViews(option =>
{
    //Register Custom exception handeller 
    option.Filters.Add(typeof(AppExceptionAttribute));
});

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(10);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
