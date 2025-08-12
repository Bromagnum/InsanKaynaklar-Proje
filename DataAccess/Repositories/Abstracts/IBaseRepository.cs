using DAL.Commen;
using DAL.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Abstracts
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<RepositoryResult<T>> CreateAsync(T entity);
        Task<RepositoryResult<T>> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

    }
}
