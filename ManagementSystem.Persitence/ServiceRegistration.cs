using ManagementSystem.Application.Repositories.Appointments;
using ManagementSystem.Application.Repositories.Users;
using ManagementSystem.Application.Token;
using ManagementSystem.Infrastructure.Services;
using ManagementSystem.Infrastructure.Services.Token;
using ManagementSystem.Persitence.Contexts;
using ManagementSystem.Persitence.Repositories.FAppointment;
using ManagementSystem.Persitence.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 

namespace ManagementSystem.Persitence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ManagementSystemDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IAppointmentReadRepository, AppointmentReadRepository>();
            services.AddScoped<IAppointmentWriteRepository, AppointmentWriteRepository>();

            services.AddScoped<ITokenHandler, TokenHandler>();
             


        }
    }
}
