using Microsoft.EntityFrameworkCore;
using Mortaltig.Domain.Services;
using Mortaltig.Infrastructure.Data.Config;
using Mortaltig.Infrastructure.Repositories;

namespace MORTALTIGV1.DependencyResolver
{
    public class DependencyResolver
    {
        public static void Register(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DbConn>(options =>
                options.UseSqlServer("name=ConnectionStrings:DefaultConn",
                x => x.MigrationsAssembly("MORTALTIGV1.Migrations")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRoadMapRepository, RoadMapRepository>();
            //services.AddScoped<IRoadMapRepository,RoadMapServices>();
            //services.AddScoped<ILoggerService, LoggerService>();
        }

        //public static void MigrateDatabase(IServiceProvider serviceProvider)
        //{
        //    var dbContextOptions = serviceProvider.GetRequiredService<DbContextOptions<DbConn>>();
        //    using (var dbContext = new DbConn(dbContextOptions))
        //    {
        //        dbContext.Database.Migrate();
        //    }
        //}
    }
}
