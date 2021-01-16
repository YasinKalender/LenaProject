using LenaProject.Dto.FormsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Dto.AppUserDtos
{
   public  class AppUserListDto
    {

        public string FirstName { get; set; }

        public string Lastaname { get; set; }

        public int Age { get; set; }

        public virtual List<FormsListDto> Forms { get; set; }
    }
}
