using Microsoft.Extensions.DependencyInjection;
using OrderItem.Domain.Interfaces;
using OrderItem.Infrastructure.Repositories;
using OrderItem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderItem.Infrastructure.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IUserRepository, UserRepository>(_ => new UserRepository(connectionString));
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
