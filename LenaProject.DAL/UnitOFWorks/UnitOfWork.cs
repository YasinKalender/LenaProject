using LenaProject.DAL.Context;
using LenaProject.DAL.Repository.Abstract;
using LenaProject.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.UnitOFWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        public ProjectContext _projectContext { get; set; }
        public IFormsRepository _formsRepository { get; set; }

        public UnitOfWork(ProjectContext projectContext)
        {
            _projectContext = projectContext;
            _formsRepository = new FormsRepository(projectContext);
        }

        

        public IBaseRepository<T> GetBaseRepository<T>() where T : class, new()
        {
            return new BaseRepository<T>(_projectContext);
        }

        public async Task Save()
        {
           await _projectContext.SaveChangesAsync();
        }
    }
}
