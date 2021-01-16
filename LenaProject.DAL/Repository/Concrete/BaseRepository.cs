using LenaProject.DAL.Context;
using LenaProject.DAL.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.Repository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {

        private readonly ProjectContext _projectContext;

        public BaseRepository(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public async Task Add(T entity)
        {
          await  _projectContext.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _projectContext.Set<T>().Remove(entity);
        }

        public async Task<List<T>> GetAll()
        {
            return await _projectContext.Set<T>().ToListAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            return await _projectContext.Set<T>().Where(expression).ToListAsync();
        }

        public async Task<T> Getbyid(int id)
        {
            return await _projectContext.Set<T>().FindAsync(id);
        }

        public async Task<T> GetOne(Expression<Func<T, bool>> expression)
        {
            return await _projectContext.Set<T>().FirstOrDefaultAsync(expression);
        }

        public void Update(T entity)
        {
            _projectContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
