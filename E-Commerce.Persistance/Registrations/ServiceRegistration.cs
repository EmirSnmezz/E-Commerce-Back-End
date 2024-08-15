using E_Commerce.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Registrations
{
    public static class ServiceRegistration
    {
        public static void AddDbContextForPostgreSQL(this IServiceCollection service)
        {
            service.AddDbContext<ECommerceContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=E_CommerceDatabase;"));
        }
    }
}
