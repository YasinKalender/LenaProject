﻿using LenaProject.Entites.ORM.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.Repository.Abstract
{
    public interface IFormsRepository:IBaseRepository<Forms>
    {

        Task<List<Forms>> WithUser(string s);

        Task<List<Forms>> Search(string s);
    }
}
