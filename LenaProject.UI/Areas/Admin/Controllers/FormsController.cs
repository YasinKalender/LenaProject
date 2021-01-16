using AutoMapper;
using LenaProject.Business.Abstract;
using LenaProject.Dto.FormsDetailsDto;
using LenaProject.Dto.FormsDtos;
using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class FormsController : Controller
    {

        private readonly IFormService _formService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IBaseService<FormsDetails> _baseService;

        public FormsController(IFormService formService, IMapper mapper, UserManager<AppUser> userManager, IBaseService<FormsDetails> baseService)
        {
            _formService = formService;
            _mapper = mapper;
            _userManager = userManager;
            _baseService = baseService;

        }
        public async Task<IActionResult> Index(string s)
        {
            ViewBag.s = s;
            return View(_mapper.Map<List<FormsListDto>>(await _formService.WithUser(s)));
        }




        [HttpPost]
        public async Task<IActionResult> FormsAdd(FormsAddDto model)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid)
            {
                await _formService.Add(new Forms()
                {
                    AppUserId = user.Id,
                    CreatedUser = user.FirstName,
                    FormName = model.FormName,
                    FormDescription = model.FormDescription

                });
                return RedirectToAction("Index");
            }


            return View(model);


        }

        public async Task<IActionResult> FormsDetails()
        {
            ViewBag.forms = new SelectList(await _formService.GetAll(), "ID", "FormName");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> FormsDetails(FormsDetailAddDto model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (ModelState.IsValid)
            {
                model.CreatedUser = user.FirstName;
                await _baseService.Add(_mapper.Map<FormsDetails>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
