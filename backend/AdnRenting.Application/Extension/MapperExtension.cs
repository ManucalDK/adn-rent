using AdnRenting.Application.Dto;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdnRenting.Application.Extension
{
    public static class MapperExtension
    {
        public static IServiceCollection AddMapperExtension(this IServiceCollection services)
        {
            AutoMapper.IConfigurationProvider config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            services.AddSingleton(config);
            services.AddScoped<IMapper, Mapper>();

            return services;
        }
    }
}
