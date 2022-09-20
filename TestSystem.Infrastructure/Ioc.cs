using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestSystem.Core.Interfaces;
using TestSystem.Infrastructure.Persistence.Data;
using TestSystem.Infrastructure.Mappings;
using TestSystem.Infrastructure.Repositories;
using TestSystem.Core.Interfaces.Base;
using TestSystem.Infrastructure.Persistence.Base;
using TestSystem.Core.Interfaces.Repositories;
using TestSystem.Core.Interfaces.Services;
using TestSystem.Infrastructure.Persistence.Service;

namespace TestSystem.Infrastructure
{
    public static class Ioc
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TestSystemDbContext>(options =>
               options.UseMySql(configuration.GetConnectionString("AppDatabase"),
               Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.36-mysql")));

            services.AddScoped<Func<TestSystemDbContext>>((provider) => () => provider.GetService<TestSystemDbContext>());

            services.AddScoped<IDbFactory<TestSystemDbContext>, DbFactory<TestSystemDbContext>>();
            services.AddScoped<IUnitOfWork<TestSystemDbContext>, UnitOfWork<TestSystemDbContext>>();

            services.AddTransient<ICaoUsuarioRepository<TestSystemDbContext>, CaoUsuarioRepository>();

            services.AddTransient<ICaoUsuarioService, CaoUsuarioService>();


            return services;
        }
    }
}
