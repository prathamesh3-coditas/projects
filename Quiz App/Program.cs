using Microsoft.EntityFrameworkCore;
using Quiz_App.Models;
using Quiz_App.Models.Services;
using Microsoft.AspNetCore.Identity;
using Quiz_App.Data;
using Microsoft.AspNetCore.Mvc;
using Quiz_App.Admin_Registration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EShoppingCodiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});


builder.Services.AddDbContext<SecurityDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SecurityDbContextConnection"));
});

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<SecurityDbContext>();


builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<SecurityDbContext>()
    .AddDefaultUI();


builder.Services.AddScoped<IDbService<SearchTable, int>, DataAccess>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();



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

app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

IServiceProvider serviceProvider = builder.Services.BuildServiceProvider();
GlobalOps.CreateApplicationAdministrator(serviceProvider);
app.Run();
