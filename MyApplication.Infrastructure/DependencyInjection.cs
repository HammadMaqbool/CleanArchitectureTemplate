using Microsoft.Extensions.DependencyInjection;
using MyApplication.Application.Interfaces;
using MyApplication.Infrastructure.DAL;
using MyApplication.Infrastructure.Services;

namespace MyApplication.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<IProductDAL, ProductDAL>();
        services.AddScoped<IEmailService, EmailService>();

        return services;
    }
}