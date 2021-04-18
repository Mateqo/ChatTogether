using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ChatTogether.Controllers
{
    public class HomeController : Controller
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

        [HttpGet("user/login")]
        public IActionResult Login()
        {
            UserLogin user = new UserLogin();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserLogin user)
        {
            var isSucces = _userService.IsSucceslogin(user.NickName, user.Password);

            if(isSucces)
            {
                HttpContext.Session.SetString("UserId", _userService.GetUserId(user.NickName).ToString());              
                HttpContext.Session.SetString("NickName", user.NickName);              
            }
            
            return View("Index");
        }

        [HttpGet("user/register")]
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
                return RedirectToAction("Index");
            }
            else
            {
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


    }
}
