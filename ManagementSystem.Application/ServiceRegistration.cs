using Microsoft.Extensions.DependencyInjection;
using MediatR;


namespace ManagementSystem.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));

            //serviceCollection.AddMediatR(typeof(ServiceRegistration));
        }
    }
}
