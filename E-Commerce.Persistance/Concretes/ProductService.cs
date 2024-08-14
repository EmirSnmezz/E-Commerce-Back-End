using E_Commerce.Application.Abstractions;
using E_Commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts()
         => new()
         {
              new() { ID = Guid.NewGuid(), Name = "Product1", Price = 100, Stock = 10, CreatedDate =  new DateTime() },
              new() { ID = Guid.NewGuid(), Name = "Product2", Price = 200, Stock = 20, CreatedDate =  new DateTime() },
              new() { ID = Guid.NewGuid(), Name = "Product3", Price = 300, Stock = 30, CreatedDate =  new DateTime() },
              new() { ID = Guid.NewGuid(), Name = "Product4", Price = 400, Stock = 40, CreatedDate =  new DateTime() }
         };
    }
}
