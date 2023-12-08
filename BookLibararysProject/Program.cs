using BookLibarary.Data_Context;
using BookLibarary.Helpers;
using BookLibarary.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DB_Context>(options =>
{ options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]); });

builder.Services.AddScoped<ICategoryRepos,CategoryRepos>();
builder.Services.AddScoped<IBookRepos, BookRepos>();

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

DbIntializer.Seed(app);

app.Run();
