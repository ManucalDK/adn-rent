using AdnRenting.Application.DataBase;
using AdnRenting.Application.Dto;
using AdnRenting.Application.Interfaces;
using AdnRenting.Application.Services;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AdnRenting.Application.Extension
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUserService, UserService>();
            return services;
        }

    }
}
