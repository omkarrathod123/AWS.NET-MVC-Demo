using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AWS.NET_MVC_Demo.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AWSNET_MVC_DemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AWSNET_MVC_DemoContext") ?? throw new InvalidOperationException("Connection string 'AWSNET_MVC_DemoContext' not found.")));

// Add services to the container.
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
