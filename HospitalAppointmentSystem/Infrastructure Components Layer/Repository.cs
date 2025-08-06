using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppointmentSystem
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        private readonly HospitalDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(HospitalDbContext context) 
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> CheckUserAsync(T entity)
        {
            try
            {
                if (entity == null) return false;
                var entityType = typeof(T);
                var idProperty = entityType.GetProperty("ID");

                if (idProperty == null)
                    return false;

                var idValue = idProperty.GetValue(entity);
                if (idValue == null) return false;

                var existingEntity = await _dbSet.FindAsync(idValue);
                return existingEntity != null;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null) { return false; }

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if(entity == null) { return null; } 
                return entity;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
