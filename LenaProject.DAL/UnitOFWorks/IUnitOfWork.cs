using LenaProject.DAL.Context;
using LenaProject.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.UnitOFWorks
{
    public interface IUnitOfWork
    {
        public ProjectContext _projectContext { get; set; }
        public IFormsRepository _formsRepository { get; set; }

        IBaseRepository<T> GetBaseRepository<T>() where T : class, new();

        Task Save();

    }
}
