﻿using ChatTogether.Application.Interfaces;
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

                HttpContext.Session.SetString("UserId", userInfo.Id.ToString()); 
                HttpContext.Session.SetString("FullName", fullName);
                HttpContext.Session.SetString("NickName", user.NickName);
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
            HttpContext.Session.Clear();
            SetMessage("Wylogowano", Application.ViewModels.Base.MessageType.Success);
            return View("Index");
        }

        [HttpGet]
        public IActionResult FindUsers(string input)
        {
           return Json(_userService.GetUsers(input));
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
