using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Dto
{
    public class BaseDto
    {

        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }

        public string CreatedUser { get; set; }

        private StatusDto _status = StatusDto.Active;
        public StatusDto Status { get { return _status; } set { _status = value; } }
    }
}
