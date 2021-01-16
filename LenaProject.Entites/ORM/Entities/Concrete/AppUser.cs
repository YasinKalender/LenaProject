using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Entites.ORM.Entities.Concrete
{
    public class AppUser:IdentityUser<int>
    {

        public string FirstName { get; set; }

        public string Lastaname { get; set; }

        public int Age { get; set; }

        public virtual List<Forms> Forms { get; set; }
    }
}
