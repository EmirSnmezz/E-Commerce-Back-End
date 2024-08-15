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
    public static class ServiceRegistration // bu class içerisindeki extension Method sayesinde IoC Container'a tanımlama yapmamızı sağlayan Registration Fonksyionlar içermektedir.
    {
        public static void AddPersistanceService(this IServiceCollection services) // extension Static fonksiyonlardır. Bir methodun extension olması için methodun static ve hangi interface/class extend edilecekse methodun parametrelerine this keywordu ile eklenmesi gerekmektedir. Yani yazmış olduğumuz fonksiyonu nereye ekleyeceğimizi belirtmiş oluyoruz 
        {
           services.AddSingleton<IProductService, ProductService>();
        }
    }
}
