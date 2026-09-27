using Microsoft.Extensions.DependencyInjection;
using MyApplication.Application.BLL;
using MyApplication.Application.Interfaces;

namespace MyApplication.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IProductBLL, ProductBLL>();

        return services;
    }
}