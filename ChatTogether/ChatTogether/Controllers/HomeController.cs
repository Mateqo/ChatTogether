using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.User;
using ChatTogether.Web.Controllers;
using ChatTogether.Web.Email;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

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
            if (_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");
        
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

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
                _userService.SetToken(userInfo.Nickname);
                HttpContext.Response.Cookies.Append("Token", userInfo.Token);
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
            if (_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            UserRegister newUser = new UserRegister();
            return View(newUser);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(UserRegister newUser)
        {
            if (ModelState.IsValid)
            {
                _userService.AddUser(newUser);
                Guid ID = Guid.NewGuid();
                string confirmationLink = Url.Action("Login", "Home", new { id = ID.ToString() }, Request.Scheme);
                Email.SendEmail(newUser.EmailAddress, newUser.Nickname, confirmationLink);
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
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            HttpContext.Response.Cookies.Delete("Token");
            HttpContext.Response.Cookies.Delete("UserId");
            HttpContext.Response.Cookies.Delete("FullName");
            HttpContext.Response.Cookies.Delete("NickName");
            SetMessage("Wylogowano", Application.ViewModels.Base.MessageType.Success);
            return View("Index");
        }

        [HttpGet]
        public IActionResult FindUsers(string input)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            return Json(_userService.GetUsers(input, HttpContext.Session.GetString("UserId")));
        }

        [HttpGet]
        public IActionResult AcceptFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.AcceptFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult RejectFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.AcceptFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult AddFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.AddFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult RemoveFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.RemoveFriend(HttpContext.Session.GetString("UserId"), friendId);
            return Ok();
        }

        public IActionResult ForgotPassword()
        {
            if (_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Main()
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            return View();
        }

        [HttpGet]
        public IActionResult Friends()
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            var firendsVieModel = _userService.GetFriendList(HttpContext.Request.Cookies["UserId"]);
            return View("Friends", firendsVieModel);
        }
    }
}

