using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SchoolProject.Infrastructure.Data;

namespace SchoolProject.Infrastructure.InfrastructureBases
{
    public class GenericRepositoryAsync<T>: IGenericRepositoryAsync<T> where T : class
    {
        #region props
        private readonly ApplicationDBContext _dBContext;

        #endregion

        #region Ctor
        public GenericRepositoryAsync(ApplicationDBContext dBContext)
        {
           _dBContext = dBContext;
        }

        #endregion

        #region Actions
        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dBContext.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetTableNoTracking()
        {
            return _dBContext.Set<T>().AsNoTracking().AsQueryable();
        }

        public IQueryable<T> GetTableAsTracking()
        {
            return _dBContext.Set<T>().AsQueryable();
        }

        public virtual async Task  AddRangeAsync(ICollection<T> entities)
        {
            await _dBContext.Set<T>().AddRangeAsync(entities);
            await _dBContext.SaveChangesAsync();    
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dBContext.Set<T>().AddAsync(entity);
            await _dBContext.SaveChangesAsync();    
            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
             _dBContext.Set<T>().Update(entity);
            await _dBContext.SaveChangesAsync();
        }


        public virtual async Task DeleteAsync(T entity)
        {
             _dBContext.Set<T>().Remove(entity);
            await _dBContext.SaveChangesAsync();
        }


        public virtual async Task DeleteRangeAsync(ICollection<T> entities)
        {
            
            foreach (var entity in entities)
            {
                _dBContext.Entry(entity).State = EntityState.Detached;  

            }
            await _dBContext.SaveChangesAsync();
        }

      

        public async Task SaveChangesAsync()
        {
            await _dBContext.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
           return _dBContext.Database.BeginTransaction();   
        }

        public void Commit()
        {
             _dBContext.Database.CommitTransaction();
        }

        public void RollBack()
        {
            _dBContext.Database.RollbackTransaction();
        }

    

      

       


        public virtual async Task UpdateRangeAsync(ICollection<T> entities)
        {
            _dBContext.Set<T>().UpdateRange(entities);
            await _dBContext.SaveChangesAsync();
        }

       

        #endregion
    }
}
