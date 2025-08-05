using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppointmentSystem
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> AddAsync(T entity)
        {
            
        }

        public Task<bool> DeleteAsync(int id)
        {
           
        }

        public Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            
        }

        public Task<List<T>> GetAllAsync()
        {
            
        }

        public Task<T> GetByIdAsync(int id)
        {
            
        }

        public Task<T> UpdateAsync(T entity)
        {
            
        }
    }
}
