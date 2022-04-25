using Thoughtful.Api.Abstractions;

namespace Thoughtful.Api.Extensions
{
    public static class ModuleExtensions
    {
        private static List<IModule> _modules = new();

        public static WebApplicationBuilder RegisterModules(this WebApplicationBuilder builder)
        {
            _modules = DiscoverModules().ToList();
            foreach (var module in _modules)
            {
                module.RegisterModule(builder);
            }

            return builder;
        }

        public static WebApplication MapEndpoints(this WebApplication app)
        {
            foreach (var module in _modules)
            {
                module.MapEndpoint(app);
            }

            return app;
        }

        private static IEnumerable<IModule> DiscoverModules()
        {
            return typeof(IModule).Assembly
                .GetTypes()
                .Where(m => m.IsClass && m.IsAssignableTo(typeof(IModule)))
                .Select(Activator.CreateInstance)
                .Cast<IModule>();
        }
    }
}
