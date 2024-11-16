using Microsoft.Extensions.DependencyInjection;
using MediatR;
using ManagementSystem.Application.Features.Commands.FUser.CreateUser;
using System.Reflection;


namespace ManagementSystem.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        { 
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
             
        }
    }
}
