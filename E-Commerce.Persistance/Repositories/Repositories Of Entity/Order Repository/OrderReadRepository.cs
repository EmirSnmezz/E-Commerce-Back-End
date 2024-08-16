using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Order_Repositories;
using E_Commerce.Domain.Entities;
using E_Commerce.Persistance.Context;
using E_Commerce.Persistance.Repositories.BaseRepositories.ReadRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Order_Repository
{
    public class OrderReadRepository : ReadRepositoryBase<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceContext context) : base(context)
        {
        }
    }
}
