using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.Repository.Abstract
{
    public interface IBaseRepository<T>
    {

        Task<List<T>> GetAll();

        Task<List<T>> GetAll(Expression<Func<T,bool>> expression);

        Task<T> GetOne(Expression<Func<T, bool>> expression);

        Task<T> Getbyid(int id);

        Task Add(T entity);

        void Delete(T entity);

        void Update(T entity);


    }
}
