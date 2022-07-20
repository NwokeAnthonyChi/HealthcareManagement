using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareManagement.Application.Persistance.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IReadOlnyList<T>> GetAll();
        Task<T> Add(T entity);
        Task Delete(int id);
        Task Update(T entity);
    }
}
