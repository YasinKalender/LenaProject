using LenaProject.DAL.Context;
using LenaProject.DAL.Repository.Abstract;
using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.Repository.Concrete
{
    public class FormsRepository:BaseRepository<Forms>,IFormsRepository
    {

        private readonly ProjectContext _projectContext;

        public FormsRepository(ProjectContext projectContext):base(projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task<List<Forms>> WithUser(string s)
        {
            var forms = _projectContext.Forms.Include(i => i.AppUser).AsQueryable();

            if (!string.IsNullOrEmpty(s))
            {
                forms = forms.Where(i => i.FormName.ToLower().Contains(s));
            }

            return await forms.ToListAsync();

        }

        public async Task<List<Forms>> Search(string s)
        {
            var forms = _projectContext.Forms.AsQueryable();

            if (!string.IsNullOrEmpty(s))
            {
                forms = forms.Where(i => i.FormName.ToLower().Contains(s));
            }

            return await forms.ToListAsync();


        }
    }
}
