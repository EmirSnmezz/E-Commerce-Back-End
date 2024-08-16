using E_Commerce.Application.Abstractions.Repositories;
using E_Commerce.Domain.Entities.Common;
using E_Commerce.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Repositories.Write_Repositories
{
    public class WriteRepositoryBase<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;

        public WriteRepositoryBase(ECommerceContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
           EntityEntry<T> entityEntry =  await Table.AddAsync(model); //EntityEntry valueTask'ın generic parameterresidir. Value Task farklı bir Task türüdür Değer türlü değerler için işlemi daha optimize edilmiş asenktron bir türdür
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddAsync(List<T> model)
        {
            await Table.AddRangeAsync(model); // birden çok veriyi, bir koleksiyonu bir anda eklemek için EfCore'da AddRange methodu kullanılır
            return true;
        }

        public bool Update(T model)
        {
           EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }

        public bool Remove(T model)
        {
            EntityEntry entityEntry = Table.Remove(model);
            return entityEntry?.State == EntityState.Deleted;
        }

        public bool Remove(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public async Task<bool> Remove(string id)
        {
            T deletedEntity = await Table.FirstOrDefaultAsync(x => x.ID == Guid.Parse(id));
            return Remove(deletedEntity);
        }


        public async Task<int> SaveAsync() // yapılan işlemler neticesinde saveChanges'ı kullanabilmek için bu fonksiyondan yararlanacağız
         => await _context.SaveChangesAsync();
    }
}
