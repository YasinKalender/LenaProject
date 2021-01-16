using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Entites.ORM.Entities.Concrete
{
    public class FormsDetails:BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int FormsID { get; set; }

        public virtual Forms Forms { get; set; }
    }
}
