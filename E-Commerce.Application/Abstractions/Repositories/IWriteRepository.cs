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
        Task<bool> RemoveAsync(T model);
        Task<bool> RemoveAsync(List<T> model);
        Task<bool> UpdateAsync(T model);
    }
}
