using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MedApp.Infrastructure
{
    public static class ServicesExtension
    {
        private static string connection = "Data Source=.\\SQLEXPRESS;Initial Catalog=MedApp;Integrated Security=True";

        public static IServiceCollection AddPersistence(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        connection,
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            return services;
        }
    }
}