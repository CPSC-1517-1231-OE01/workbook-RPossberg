using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//***************************************************************
// Required namespaces
using WestWindSystem.BLL;
using WestWindSystem.DAL;
//***************************************************************

namespace WestWindSystem
{
    public static class BackEndExtensions
    {
        public static void WwBackEndDependencies(this IServiceCollection services,
            Action<DbContextOptionsBuilder> options)
        {
            // Now, register all services that will be used by the system(context setup)
            // and will be provided by the system (BLL services)

            // Register the context service
            // "options" contains the connection string information
            _ = services.AddDbContext<WestWindContext>(options);

            // Register EACH service class (BLL classes)
            // Each service class will have an AddTransient<T>() method call

            // AddTransient<T>() method to add service classes, where T is the class name
            // AddTransient is called a factory method
            _ = services.AddTransient<CustomerServices>((serviceProvider) =>
            {
                WestWindContext? context = serviceProvider.GetService<WestWindContext>();

                // Create an instance of the service class (CustomerServices)
                // supplying the context reference to the service class - this is where we
                // pass in the required context to the internal constructor (must be
                // performed from within the assembly, which this class (BackEndExtensions) is.
                return new CustomerServices(context!);
            });

            _ = services.AddTransient<CategoryServices>((serviceProvider) =>
            {
                WestWindContext? context = serviceProvider.GetService<WestWindContext>();
                return new CategoryServices(context!);
            });

            _ = services.AddTransient<ProductServices>((serviceProvider) =>
            {
                WestWindContext? context = serviceProvider.GetService<WestWindContext>();
                return new ProductServices(context!);
            });

            _ = services.AddTransient<SupplierServices>((serviceProvider) =>
            {
                WestWindContext? context = serviceProvider.GetService<WestWindContext>();
                return new SupplierServices(context!);
            });
        }
    }
}