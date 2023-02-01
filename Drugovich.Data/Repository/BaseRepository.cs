using Drugovich.Data.Context;
using Drugovich.Domain.Entities.Base;
using Drugovich.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DrugovichContext _context;
        private DbSet<T> _dataSet;
        public BaseRepository(DrugovichContext context)
        {
            this._context = context;
            this._dataSet = _context.Set<T>();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(p => p.Id == id);
                if (result == null) return false;

                _dataSet.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<T> GetAsync(int id)
        {
            try
            {
                return await _dataSet.FirstOrDefaultAsync(p => p.Id.Equals(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<T> InsertAsync(T entity)
        {
            try
            {
               
                entity.CreatAt = DateTime.UtcNow;
                _dataSet.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            try
            {
                var result = await _dataSet.FirstOrDefaultAsync(p => p.Id == entity.Id);
                if (result == null) return null;

                entity.UpdateAt = DateTime.UtcNow;
                entity.CreatAt = result.CreatAt;

                _context.Entry(result).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;

        }
    }
}
