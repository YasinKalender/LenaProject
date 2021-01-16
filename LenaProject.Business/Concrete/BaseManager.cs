using LenaProject.Business.Abstract;
using LenaProject.DAL.UnitOFWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.Concrete
{
    public class BaseManager<T> : IBaseService<T> where T : class, new()
    {

        private readonly IUnitOfWork _unitOfWork;

        public BaseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Add(T entity)
        {
            await _unitOfWork.GetBaseRepository<T>().Add(entity);
            await _unitOfWork.Save();
        }

        public async void Delete(T entity)
        {
            _unitOfWork.GetBaseRepository<T>().Delete(entity);
            await _unitOfWork.Save();
        }

        public async Task<List<T>> GetAll()
        {
            return await _unitOfWork.GetBaseRepository<T>().GetAll();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression)
        {
            return await _unitOfWork.GetBaseRepository<T>().GetAll(expression);
        }

        public async Task<T> Getbyid(int id)
        {
            return await _unitOfWork.GetBaseRepository<T>().Getbyid(id);
        }

        public async Task<T> GetOne(Expression<Func<T, bool>> expression)
        {
            return await _unitOfWork.GetBaseRepository<T>().GetOne(expression);
        }

        public async void Update(T entity)
        {
            _unitOfWork.GetBaseRepository<T>().Update(entity);
            await _unitOfWork.Save();
        }
    }
}
