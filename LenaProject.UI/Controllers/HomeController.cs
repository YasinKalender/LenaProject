using AutoMapper;
using LenaProject.Business.Abstract;
using LenaProject.Dto.AppUserDtos;
using LenaProject.Dto.FormsDtos;
using LenaProject.Entites.ORM.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LenaProject.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IFormService _formService;
        private readonly IMapper _mapper;

        

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IFormService formService, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _formService = formService;
            _mapper = mapper;
        }

   
        public async Task<IActionResult> Index(string s)
        {
            ViewBag.s = s;

            return View(_mapper.Map<List<FormsListDto>>(await _formService.Search(s)));
        }

        public IActionResult Register()
        {

            return View();
        }


        [HttpPost,AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(AppUserRegisterDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    FirstName = model.FirstName,
                    Lastaname = model.Lastaname,
                    Age = model.Age,
                    Email = model.Email,
                    UserName = model.Username,




                };

                var result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    var role = await _userManager.AddToRoleAsync(appUser, "Member");

                    if (role.Succeeded)
                    {
                        return RedirectToAction("/Home/Login");
                    }

                    else
                    {
                        foreach (var item in role.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }




            return View();
        }


        public IActionResult Login()
        {

            return View();
        }


        [ValidateAntiForgeryToken,HttpPost]
        public async Task<IActionResult> Login(AppUserLoginDto model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        var role = await _userManager.GetRolesAsync(user);
                        if (role.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Forms", new { area = "Admin" });
                        }
                    }



                }


                ModelState.AddModelError("", "Kullanıcı Adı veya şifre yanlış");
            }

            return View(model);
        }

        public IActionResult Form(int id)
        {

            return View();
        }
    }
}
