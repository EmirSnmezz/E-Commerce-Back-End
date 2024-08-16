using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Product_Repositories;
using E_Commerce.Domain.Entities;
using E_Commerce.Persistance.Context;
using E_Commerce.Persistance.Repositories.BaseRepositories.ReadRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Product_Repository
{
    public class ProductReadRepository : ReadRepositoryBase<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceContext context) : base(context)
        {
        }
    }
}
