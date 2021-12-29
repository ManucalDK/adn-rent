using AdnRenting.Infrastructure.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AdnRenting.Application.Extension
{
    public static class DBExtension
    {
        public static IServiceCollection AddDBExtension(this IServiceCollection services)
        {
            services.AddDbContext<AdnDBContext>(opt => opt.UseInMemoryDatabase("AdnMemoryDB"));

            return services;
        }
    }
}
