
namespace Nomina.API
{

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Razor;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Nomina.Infrastructure.Context;
    using Nomina.ServicesInterfaces;
    using Nomina.Services;
    using Nomina.Core.RepositoriesInterfaces;
    using Nomina.Infrastructure.Repositories;
    using Nomina.Infrastructure;

    public static class ConfigureContainerExtensions
    {
        public static void AddDbContext(this IServiceCollection serviceCollection, string dataConnectionString = null)
        {
            serviceCollection.AddDbContext<DataContext>(options =>
               options.UseSqlite(dataConnectionString ?? GetDataConnectionStringFromConfig()));

            //serviceCollection.AddDbContext<DataContext>(cfg =>
            //{
            //    cfg.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection"));
            //});
        }

        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            serviceCollection.AddScoped(typeof(IEmployeeRepository), typeof(EmployeeRepository));
        }

        public static void AddTransientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmployeeService, EmployeeService>();
           
        }

        /// <summary>
        /// Adds rules to the <see cref="RazorViewEngineOptions"/> for dealing with Feature Folders
        /// </summary>
        /// <param name="serviceCollection">
        /// The <see cref="IServiceCollection"/> created in <see cref="Startup.ConfigureServices"/>
        /// </param>
        //public static void AddFeatureFolders(this IServiceCollection serviceCollection)
        //{
        //    serviceCollection.Configure<RazorViewEngineOptions>(options =>
        //    {
        //        options.ViewLocationExpanders.Add(new FeatureLocationExpander());
        //    });
        //}

        private static string GetDataConnectionStringFromConfig()
        {
            return new DatabaseConfiguration().GetDataConnectionString();
        }

        //private static string GetAuthConnectionFromConfig()
        //{
        //    return new DatabaseConfiguration().GetAuthConnectionString();
        //}

    }
}
