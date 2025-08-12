using DAL.Commen;
using DAL.Context;
using DAL.Entities.Abstracts;
using DAL.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concretes
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IKDbContext _context;
        public BaseRepository(IKDbContext ıKDbContext)
        {
            _context = ıKDbContext;
        }
        public async Task<RepositoryResult<T>> CreateAsync(T entity)
        {
            try
            {
                entity.CreatedAudit();
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return new RepositoryResult<T> { Success = true, Entity = entity };
            }
            catch (Exception ex)
            {
                return new RepositoryResult<T>
                {
                    Success = false,
                    ErrorMessage = ex.Message
                };

            }
        }

        public async Task DeleteAsync(T entity)
        {
            //var entity = await GetByIdAsync(id);
            //if (entity != null)
            //{
            //    _context.Set<T>().Remove(entity);
            //    await _context.SaveChangesAsync();
            //}
            _context.Set<T>().Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            return entity;
        }

        public async Task<RepositoryResult<T>> UpdateAsync(T entity)
        {
            try
            {
                entity.UpdatedAudit();
                _context.Set<T>().Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return new RepositoryResult<T> { Entity = entity, Success = true };
            }
            catch
            {
                return new RepositoryResult<T>
                {
                    Success = false,
                    ErrorMessage = "An error occurred while updating the entity."
                };
            }
        }
    }
}
