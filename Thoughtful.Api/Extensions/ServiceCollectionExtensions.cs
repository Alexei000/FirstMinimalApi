using Thoughtful.Dal;

namespace Thoughtful.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, ConfigurationManager configuration)
        {
            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<ThoughtfulDbContext>(
                opt => opt.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddMediatR(typeof(Program));
            services.AddAutoMapper(typeof(Program));

            return services;
        }
    }
}
