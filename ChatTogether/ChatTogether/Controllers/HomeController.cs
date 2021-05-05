using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Web.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
                var userInfo = _userService.GetUserByNickName(user.NickName);
                var fullName = userInfo.Name + " " +  userInfo.Surname;

                HttpContext.Response.Cookies.Append("UserId", userInfo.Id.ToString());
                HttpContext.Response.Cookies.Append("FullName", fullName);
                HttpContext.Response.Cookies.Append("NickName", userInfo.Nickname);
                ViewBag.fullname = fullName;
                ViewBag.nickname = userInfo.Nickname;

                return View("Main");
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

        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Response.Cookies.Delete("UserId");
            HttpContext.Response.Cookies.Delete("FullName");
            HttpContext.Response.Cookies.Delete("NickName");
            SetMessage("Wylogowano", Application.ViewModels.Base.MessageType.Success);
            return View("Index");
        }

        [HttpGet]
        public IActionResult FindUsers(string input)
        {
           return Json(_userService.GetUsers(input, HttpContext.Session.GetString("UserId")));
        }

        [HttpGet]
        public IActionResult AcceptFriend(int friendId)
        {
            _userService.AcceptFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult RejectFriend(int friendId)
        {
            _userService.AcceptFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
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

        [HttpGet]
        public IActionResult Friends()
        { 
            return View("Friends");
        }
    }
}

