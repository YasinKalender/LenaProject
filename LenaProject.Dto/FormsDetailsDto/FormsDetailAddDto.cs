using LenaProject.Dto.FormsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Dto.FormsDetailsDto
{
    public class FormsDetailAddDto:BaseDto
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int FormsID { get; set; }

        public FormsListDto Forms { get; set; }
    }
}
