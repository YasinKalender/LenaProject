using LenaProject.Dto.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Dto.FormsDtos
{
    public class FormsListDto:BaseDto
    {

        public string FormName { get; set; }

        public string FormDescription { get; set; }

        public int AppUserId { get; set; }

        public virtual AppUserListDto AppUser { get; set; }
    }
}
