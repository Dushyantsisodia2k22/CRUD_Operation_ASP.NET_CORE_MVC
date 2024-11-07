using Microsoft.EntityFrameworkCore;
using MNJ_CRUD_OPERATION_FINAL.Data;

namespace MNJ_CRUD_OPERATION_FINAL.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {

        private readonly ApplicationDBContext context;
        private readonly DbSet<T> _dbSet;
        public GenericRepo(ApplicationDBContext context)
        {
            this.context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unbale to add data in database ", ex);
            }
        }

        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id);

                if (result == null)
                {
                    return false;
                }

                _dbSet.Remove(result);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unable to delete the data ", ex);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occur while retriving entities ", ex);
            }
        }

        public async Task<T> GetByIdAsync(long id)
        {
            try
            {
                var result = await _dbSet.FindAsync(id);

                if (result == null)
                {
                    throw new ApplicationException("Detail not found");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Problem occur while retriving data from Database"+ ex);
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new ApplicationException("An error occur while updating entities ", ex);
            }
        }
    }
}
