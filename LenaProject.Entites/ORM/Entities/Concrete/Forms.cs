using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Entites.ORM.Entities.Concrete
{
    public class Forms:BaseEntity
    {
        public string FormName { get; set; }

        public string FormDescription { get; set; }

        public int AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public virtual List<FormsDetails> FormsDetails { get; set; }

    }
}
