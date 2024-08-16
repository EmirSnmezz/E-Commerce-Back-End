using E_Commerce.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using E_Commerce.Persistance.Configurations;
using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Customer_Repositories;
using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Order_Repositories;
using E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Customer_Repository;
using E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Order_Repository;
using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Product_Repositories;
using E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Product_Repository;

namespace E_Commerce.Persistance.Registrations
{
    public static class ServiceRegistration
    {
        public static void AddDbContextForPostgreSQL(this IServiceCollection service)
        {
            service.AddDbContext<ECommerceContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=E_CommerceDatabase;"), ServiceLifetime.Singleton);
            service.AddSingleton<ECommerceContext, ECommerceContext>();
            service.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            service.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
            service.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            service.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            service.AddSingleton<IProductReadRepository, ProductReadRepository>();
            service.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
