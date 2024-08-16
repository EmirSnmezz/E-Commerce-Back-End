using E_Commerce.Application.Abstractions.Repositories;
using E_Commerce.Domain.Entities.Common;
using E_Commerce.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.ReadRepositories
{
    public class ReadRepositoryBase<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        public ReadRepositoryBase(ECommerceContext context) 
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();


        public IQueryable<T> GetAll()
            => Table; // Table DbSet'tir DbSet'in kendisini döndürmek demek o tablonun hepsini, içindeki verilerin tamamını döndürmek demek olacağı için bu şekilde bir tanımlama yaparak ilgili tablodaki tüm verileri döndürebiliriz

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(data => data.ID == Guid.Parse(id));

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> condition)
            => await Table.FirstOrDefaultAsync(condition);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> condition)
            => Table.Where(condition);
    }
}
