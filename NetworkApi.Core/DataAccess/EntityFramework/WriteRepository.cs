using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using NetworkApi.Core.DataAccess.Interfaces;
using NetworkApi.Core.Entities.Common;

namespace NetworkApi.Core.DataAccess.EntityFramework
{
    public class WriteRepository<T, TContext> : IWriteRepository<T> where T : BaseEntity where TContext : DbContext, new()
    {
        public async Task AddAsync(T model)
        {
            using TContext context = new();
            EntityEntry<T> entityEntry = await context.Set<T>().AddAsync(model);
            entityEntry.State = EntityState.Added;
            await context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<T> models)
        {
            using TContext context = new();
            await context.AddRangeAsync(models);
            await context.SaveChangesAsync();
        }

        public void Delete(T model)
        {
            using TContext context = new();
            EntityEntry<T> entityEntry = context.Set<T>().Remove(model);
            entityEntry.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public async Task DeleteById(string id)
        {
            using TContext context = new();
            T model = await context.Set<T>().FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            Delete(model);
        }

        public async void DeleteRange(List<T> models)
        {
            using TContext context = new();
            context.Set<T>().RemoveRange(models);
            context.SaveChanges();
        }

        public void Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}