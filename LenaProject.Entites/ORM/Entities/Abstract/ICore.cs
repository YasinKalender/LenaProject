using LenaProject.Entites.ORM.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.Entites.ORM.Entities.Abstract
{
    public interface ICore
    {

        int ID { get; set; }

        DateTime AddDate { get; set; }

        string CreatedUser { get; set; }

        Status Status { get; set; }

    }
}
