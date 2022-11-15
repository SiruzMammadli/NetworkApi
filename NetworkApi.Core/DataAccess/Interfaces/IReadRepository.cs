using System.Linq.Expressions;
using NetworkApi.Core.Entities.Common;

namespace NetworkApi.Core.DataAccess.Interfaces
{
    public interface IReadRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetById(Expression<Func<T, bool>> method, bool tracking = true);
    }
}