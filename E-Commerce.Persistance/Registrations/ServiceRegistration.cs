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
            service.AddDbContext<ECommerceContext>(options => options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=E_CommerceDatabase;"));
            service.AddScoped<ECommerceContext, ECommerceContext>();
            service.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            service.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            service.AddScoped<IOrderReadRepository, OrderReadRepository>();   // burada servislerin LifeCycle'ını AddScoped yaptığımız zaman patlıyor bunun sebebi ->
                                                                              // Request Geliyor, Bu requestin Controller'a gelmesinden sonra controller ilgili dependency'nin kendisine sağlanması için Ioc Container'a talepte bulunarak ilgili nesneyi talep ediyor. Oradaki nesne Scoped olarak oraya konduysa ve gelen requeste karşılık o nesneye kaç kere talepte bulunuluyorsa (uygulamanın farklı noktalarında) her birine tüm inject taleplerine aynı nesne gönderilir. Yeni bir request'ye yeni bir nesne oluşturup gene tüm inject'lere aynı nesne gönderilir.
                                                                              // Transient'de ise Herhangi bir request için bir nesne oluşturulur ilgili injecte oluşturulan nesne gönderilir başka bir request gelirse ilgili request için yeni bir nesne oluşturulup yeni nesneyi ilgili injecte gönderir
            service.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            service.AddScoped<IProductReadRepository, ProductReadRepository>();
            service.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }

    }
}
