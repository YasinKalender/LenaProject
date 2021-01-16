using LenaProject.Business.Abstract;
using LenaProject.DAL.UnitOFWorks;
using LenaProject.Entites.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Business.Concrete
{
    public class FormManager:BaseManager<Forms>,IFormService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormManager(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Forms>> Search(string s)
        {
            return await _unitOfWork._formsRepository.Search(s);
        }

        public async Task<List<Forms>> WithUser(string s)
        {
            return await _unitOfWork._formsRepository.WithUser(s);
        }
    }
}
