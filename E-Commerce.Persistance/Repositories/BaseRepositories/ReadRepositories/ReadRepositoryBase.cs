using E_Commerce.Application.Abstractions.Repositories;
using E_Commerce.Domain.Entities.Common;
using E_Commerce.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.BaseRepositories.ReadRepositories
{
    public class ReadRepositoryBase<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        public ReadRepositoryBase(ECommerceContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();


        public IQueryable<T> GetAll(bool tracking = true)
            {
            IQueryable<T> query = Table.AsQueryable();

            if(!tracking)
            {
                query = query.AsNoTracking();  // tracking değeri false ise tracking mekanizmasına ilgili değerimiz dahil edilmesin
            }

            return query;
            } // Table DbSet'tir DbSet'in kendisini döndürmek demek o tablonun hepsini, içindeki verilerin tamamını döndürmek demek olacağı için bu şekilde bir tanımlama yaparak ilgili tablodaki tüm verileri döndürebiliriz

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(x => x.ID == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> condition, bool tracking = true)
        {
            var query = Table.AsQueryable();

            if(!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(condition);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> condition, bool tracking = true)
          {
            IQueryable<T> query = Table.Where(condition);

            if(!tracking)
            {
                query = query.AsNoTracking();
            }

            return query;
          }
    }
}
