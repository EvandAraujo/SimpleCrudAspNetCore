using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SimpleCrudBackEndNetCore.Infra.Context;
using System.Data;

namespace SimpleCrudBackEndNetCore.WebApi.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration) 
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MicroServiceContext>(options => options.UseSqlServer(connectionString));
            services.AddTransient<IDbConnection>((sp) => new SqlConnection(connectionString));
        }
    }
}
