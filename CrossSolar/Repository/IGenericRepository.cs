using System.Linq;
using System.Threading.Tasks;

namespace CrossSolar.Repository
{
    public interface IGenericRepository<T>
    {
        Task<T> GetAsync(string id);

        IQueryable<T> Query();

        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);
    }
}