using ChatTogether.Application.Interfaces;
using ChatTogether.Application.ViewModels.Chat;
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
            {
                HttpContext.Response.Cookies.Delete("Token");
                HttpContext.Response.Cookies.Delete("UserId");
                HttpContext.Response.Cookies.Delete("FullName");
                HttpContext.Response.Cookies.Delete("NickName");
            }

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

            if (isSucces)
            {
                var userInfo = _userService.GetUserByNickName(user.NickName);
                var fullName = userInfo.Name + " " + userInfo.Surname;
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
                SetMessage("Błędne dane lub niepotwierdzony e-mail.", Application.ViewModels.Base.MessageType.Error);
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
            if (!_userService.CheckNameUniqueness(newUser.Nickname))
            {
                ModelState.AddModelError("Nickname", "Użytkownik o podanej nazwie już istnieje.");
            }
            if (!_userService.CheckEmailUniqueness(newUser.EmailAddress))
            {
                ModelState.AddModelError("EmailAddress", "Użytkownik z takim mailem już istnieje.");
            }

            if (ModelState.IsValid)
            {
                _userService.AddUser(newUser);
                Guid ID = Guid.NewGuid();
                string confirmationLink = Url.Action("AccountConfirmation", "Home", new { id = ID.ToString() }, Request.Scheme);
                Email.SendEmail(newUser.EmailAddress, newUser.Nickname, confirmationLink);
                _userService.AddConfirmation(ID, newUser);
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
            var list = _userService.GetUsers(input, HttpContext.Request.Cookies["UserId"]);

            return Json(_userService.CheckSend(list, HttpContext.Request.Cookies["UserId"]));
        }

        [HttpGet]
        public IActionResult AcceptFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.AcceptFriend(HttpContext.Request.Cookies["UserId"], friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult RejectFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.RejectFriend(HttpContext.Request.Cookies["UserId"], friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult AddFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.AddFriend(HttpContext.Request.Cookies["UserId"], friendId);
            return Ok();
        }

        [HttpGet]
        public IActionResult RemoveFriend(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            _userService.RemoveFriend(HttpContext.Request.Cookies["UserId"], friendId);
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

            var friendsViewModel = _userService.GetFriendList(HttpContext.Request.Cookies["UserId"]);
            return View("Friends", friendsViewModel);
        }

        [HttpGet]
        public IActionResult AccountConfirmation()
        {
            _userService.AccountConfirmation(Url.ActionContext.RouteData.Values["id"].ToString());
            SetMessage("Twoje konto zostało aktywowane", Application.ViewModels.Base.MessageType.Success);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Chat(int friendId)
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            ChatViewModel chat = new ChatViewModel();
            chat.UserId = Convert.ToInt32(HttpContext.Request.Cookies["UserId"]);
            chat.FriendId = friendId;
            var friend = _userService.GetUserById(friendId);
            chat.FriendFullName = friend.Name + " " + friend.Surname + " (" + friend.Nickname + ")";
            chat.FriendNick = friend.Nickname;
            chat.UserNick = _userService.GetUserById(Convert.ToInt32(HttpContext.Request.Cookies["UserId"])).Nickname;
            chat.MessageList = _userService.GetMessage(Convert.ToInt32(HttpContext.Request.Cookies["UserId"]), friendId);
            return View("Chat",chat);
        }

        [HttpGet]
        public IActionResult Editprofile()
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeNickname(UserEditProfile userEditProfile)
        {
            string message = "Błąd: ";
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            if (!_userService.IsSucceslogin(HttpContext.Request.Cookies["NickName"], userEditProfile.CurrentPassword))
            {
                ModelState.AddModelError("CurrentPassword", "Hasło niepoprawne");
                message += "Hasło niepoprawne";
            }
            else if (string.IsNullOrWhiteSpace(userEditProfile.NewNickname))
            {
                ModelState.AddModelError("NewNickname", "Proszę wprowadzić dane");
                message += "Proszę wprowadzić dane";
            }
            else if (!_userService.CheckNameUniqueness(userEditProfile.NewNickname))
            {
                ModelState.AddModelError("NewNickname", "Użytkownik o podanej nazwie już istnieje");
                message += "Użytkownik o podanej nazwie już istnieje";
            }

            if (ModelState.IsValid)
            {
                _userService.ChangeNickname(HttpContext.Request.Cookies["UserId"], userEditProfile.NewNickname);
                HttpContext.Response.Cookies.Append("NickName", userEditProfile.NewNickname);
                SetMessage("Login został zmieniony", Application.ViewModels.Base.MessageType.Success);
            }
            else
            {
                if (message == "Błąd: ")
                {
                    message += "Wprowadzony login jest nieodpowiedniej długości";
                }
                SetMessage(message, Application.ViewModels.Base.MessageType.Error);
            }
            return RedirectToAction("Editprofile");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeEmail(UserEditProfile userEditProfile)
        {
            string message = "Błąd: ";
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            if (!_userService.IsSucceslogin(HttpContext.Request.Cookies["NickName"], userEditProfile.CurrentPassword))
            {
                ModelState.AddModelError("CurrentPassword", "Hasło niepoprawne");
                message += "Hasło niepoprawne";
            }
            else if (string.IsNullOrWhiteSpace(userEditProfile.NewEmail) || string.IsNullOrWhiteSpace(userEditProfile.NewEmailRep))
            {
                ModelState.AddModelError("NewEmail", "Proszę wprowadzić dane");
                message += "Proszę wprowadzić dane";
            }
            else if (!_userService.CheckEmailUniqueness(userEditProfile.NewEmail))
            {
                ModelState.AddModelError("NewEmail", "Email zajęty");
                message += "Email zajęty";
            }
            if (userEditProfile.NewEmail != userEditProfile.NewEmailRep)
            {
                ModelState.AddModelError("NewEmailRep", "E-maile różnią się");
                message += "Podane Emaile różnią się od siebie";
            }

            if (ModelState.IsValid)
            {
                _userService.ChangeEmail(HttpContext.Request.Cookies["UserId"], userEditProfile.NewEmail);
                SetMessage("E-mail został zmieniony", Application.ViewModels.Base.MessageType.Success);
            }
            else
            {
                if (message == "Błąd: ")
                {
                    message += "Wprowadzony mail jest błędny";
                }
                SetMessage(message, Application.ViewModels.Base.MessageType.Error);
            }
            return RedirectToAction("Editprofile");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangePassword(UserEditProfile userEditProfile)
        {
            string message = "Błąd: ";
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            if (!_userService.IsSucceslogin(HttpContext.Request.Cookies["NickName"], userEditProfile.CurrentPassword))
            {
                ModelState.AddModelError("CurrentPassword", "Stare hasło niepoprawne");
                message += "Stare hasło niepoprawne";
            }
            else if (string.IsNullOrWhiteSpace(userEditProfile.NewPassword) || string.IsNullOrWhiteSpace(userEditProfile.NewPasswordRep))
            {
                ModelState.AddModelError("NewPassword", "Proszę wprowadzić dane");
                message += "Proszę wprowadzić dane";
            }
            else if(userEditProfile.NewPassword != userEditProfile.NewPasswordRep)
            {
                ModelState.AddModelError("NewPasswordRep", "Hasła nie są takie same");
                message += "Hasła nie są takie same";
            }

            if (ModelState.IsValid)
            {
                _userService.ChangePassword(HttpContext.Request.Cookies["UserId"], userEditProfile.NewPassword);
                SetMessage("Hasło zostało zmienione", Application.ViewModels.Base.MessageType.Success);
            }
            else
            {
                if(message == "Błąd: ")
                {
                    message += "Wprowadzone hasło jest nieodpowiedniej długości";
                }
                SetMessage(message, Application.ViewModels.Base.MessageType.Error);
            }
            return RedirectToAction("Editprofile");
        }

        [HttpGet]
        public IActionResult Chats()
        {
            if (!_userService.ValidateUser(HttpContext.Request.Cookies["NickName"], HttpContext.Request.Cookies["UserId"], HttpContext.Request.Cookies["Token"]))
                return View("BadRequest");

            return View();
        }
    }
}

