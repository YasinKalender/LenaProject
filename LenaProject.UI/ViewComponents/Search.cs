using LenaProject.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.ViewComponents
{
    public class Search:ViewComponent
    {
        private readonly IFormService _formService;

        public Search(IFormService formService)
        {
            _formService = formService;
        }


        public IViewComponentResult Invoke(string s)
        {


            return View(_formService.Search(s).Result);
        }
    }
}
