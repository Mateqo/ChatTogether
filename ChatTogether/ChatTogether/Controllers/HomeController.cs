using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Application.ViewModels.Base;
using ChatTogether.Web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Newtonsoft.Json;

namespace ChatTogether.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            UserLogin user = new UserLogin();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLogin user)
        {
            var isSucces = _userService.IsSucceslogin(user.NickName, user.EncryptedPassword);

            if(isSucces)
            {
                SetMessage("Zalogowano", Application.ViewModels.Base.MessageType.Success);
                HttpContext.Session.SetString("UserId", _userService.GetUserId(user.NickName).ToString());              
                HttpContext.Session.SetString("NickName", user.NickName);
                return View("Index");
            }
            else
            {
                SetMessage("Błędne dane", Application.ViewModels.Base.MessageType.Error);
                return View(user);
            }
            
            
        }

        [HttpGet]
        public IActionResult Registration()
        {
            UserRegister newUser = new UserRegister();
            return View(newUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(UserRegister newUser)
        {   
            if(ModelState.IsValid)
            {
                _userService.AddUser(newUser);
                SetMessage("Dodano użytkownika", Application.ViewModels.Base.MessageType.Success);
                return RedirectToAction("Index");
            }
            else
            {
                SetMessage("Uzupełnij wymagane pola", Application.ViewModels.Base.MessageType.Error);
                return View(newUser);
            }          
        }


        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }


    }
}
