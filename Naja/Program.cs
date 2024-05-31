using Microsoft.EntityFrameworkCore;

using Naja.Models;

using Pomelo.EntityFrameworkCore.MySql;

DotNetEnv.Env.Load("../.env");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = $"Server={DotNetEnv.Env.GetString("SERVER")};Database={DotNetEnv.Env.GetString("DATABASE")};User={DotNetEnv.Env.GetString("USER")};Password={DotNetEnv.Env.GetString("PASSWORD")};";

builder.Services.AddDbContext<XiContext>(options => options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    ));

builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
