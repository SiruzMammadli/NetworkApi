using NetworkApi.Core.Entities.Common;

namespace NetworkApi.Core.DataAccess.Interfaces
{
    public interface IWriteRepository<T> : IRepositoryBase<T> where T : BaseEntity
    {
        Task AddAsync(T model);
        Task AddRangeAsync(List<T> models);
        void Update(T model);
        void Delete(T model);
        void DeleteRange(List<T> models);
        Task DeleteById(string id);
    }
}