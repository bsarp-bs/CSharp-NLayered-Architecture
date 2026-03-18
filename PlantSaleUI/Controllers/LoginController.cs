using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlantSaleUI.Models;

namespace PlantSaleUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _logger;
        private readonly SignInManager<IdentityUser> _signin;

        public LoginController(UserManager<IdentityUser> logger, SignInManager<IdentityUser> signin)
        {
            _logger = logger;
            _signin = signin;
        }

        [HttpGet]
        public IActionResult LoginIndex()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginIndex(SignInViewModel signmodel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signin.PasswordSignInAsync(signmodel.username, signmodel.password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("DashboardIndex", "Dashboard");
                }
                else
                {
                    return RedirectToAction("LoginIndex");
                }
            }
            else
            {
                return RedirectToAction("LoginIndex");
            }

            
        }

        [HttpGet]
        public IActionResult LogIN()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIN(RegisterModel _RegisterModel)
        {
            //Insert kısmında hata olmaması için id 2 olarak verildi

            IdentityUser user = new IdentityUser()
            {
                Id = "2",
                UserName = _RegisterModel.UserName,
                Email = _RegisterModel.Mail
            };

            if (_RegisterModel.Password == _RegisterModel.PasswordConfirm)
            {
                var result = await _logger.CreateAsync(user, _RegisterModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("LoginIndex");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(_RegisterModel);
        }
    }
}
