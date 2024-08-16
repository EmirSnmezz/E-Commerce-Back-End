using E_Commerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Abstractions.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddAsync(List<T> model); // diyelim ki bir liste geldi bize bu listeyi/koleksiyonu toplu bir şekilde db'ye eklemek istiyoruz. İşte bunun için AddAsync fonksiyonumuzun bir overload'ını oluşturduk
        bool Remove(T model);
        bool Remove(List<T> model);
        Task<bool> Remove (string id);
        bool Update(T model);
        Task<int> SaveAsync (); // Yapılan işlemler neticesinde saveChanges'ı kullanabilmek için bu fonksiyonu kullanacağız
    }
}
