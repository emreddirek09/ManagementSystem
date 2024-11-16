using ManagementSystem.Persitence;
using ManagementSystem.Application;
using ManagementSystem.Domain;
using ManagementSystem.Application.Repositories; 
using ManagementSystem.Persitence.Contexts;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentity<User, UserRole>().AddEntityFrameworkStores<ManagementSystemDbContext>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Signin/Index");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Signup}/{action=Index}/{id?}");

app.Run();
