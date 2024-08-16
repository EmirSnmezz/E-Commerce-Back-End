using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Customer_Repositories;
using E_Commerce.Domain.Entities;
using E_Commerce.Persistance.Context;
using E_Commerce.Persistance.Repositories.Write_Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.Repositories_Of_Entity.Customer_Repository
{
    public class CustomerWriteRepository : WriteRepositoryBase<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceContext context) : base(context)
        {
        }
    }
}
