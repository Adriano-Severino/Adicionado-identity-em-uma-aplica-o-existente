using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.AccountViewModel;
using WebApplication1.Models.ManagerViewModel;

namespace WebApplication1.Controllers
{
    

    public class ManageController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ManageController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData]
        public  string StatusMessage { get; set; }

        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                throw new ApplicationException($"Não foi possivel carregar o usuário com o ID '{user.Id}'");
            }

            var model = new IndexViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                IsEmailConfirmed = user.EmailConfirmed,
                StatusMessage = StatusMessage,
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                throw new ApplicationException($"Não foi possivel carregar o usuário com o ID '{user.Id}'");
            }

            var email = user.Email;

            if (email != model.Email)
            {
                var setEmailIResult = await _userManager.SetEmailAsync(user, model.Email);

                if (!setEmailIResult.Succeeded)
                {
                    throw new ApplicationException($"erro inesperado ao atribuir um email para o usuario com ID '{user.Id}'");
                }
            }

            var phoneNumber = user.PhoneNumber;

            if (phoneNumber != model.PhoneNumber)
            {
                var setPhoneResult = await _userManager.SetEmailAsync(user, model.Email);

                if (!setPhoneResult.Succeeded)
                {
                    throw new ApplicationException($"erro inesperado ao atribuir um telefone para o usuario com ID '{user.Id}'");
                }
            }

            StatusMessage = "Seu perfil foi atualizado";

            return RedirectToAction((nameof(Index)));
        }
    }

}