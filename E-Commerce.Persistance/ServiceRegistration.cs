using E_Commerce.Application.Abstractions;
using E_Commerce.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection services)
        {
           services.AddSingleton<IProductService, ProductService>();
        }
    }
}
