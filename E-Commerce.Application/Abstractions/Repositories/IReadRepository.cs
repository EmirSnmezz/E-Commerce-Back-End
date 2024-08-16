using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Abstractions.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> condition);
        T GetById(Guid id);
    }
}
