using Microsoft.AspNetCore.Mvc;
using ChatTogether.Application.ViewModels.Base;

namespace ChatTogether.Web.Controllers
{
    public class BaseController : Controller
    {
        public void SetMessage(string message, MessageType type)
        {
            TempData["SM"] = message;
            TempData["SMT"] = type;
        }
    }
}
