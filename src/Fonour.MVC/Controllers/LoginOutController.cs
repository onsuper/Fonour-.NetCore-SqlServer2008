using Fonour.Application.UserApp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fonour.MVC.Controllers
{
    public class LoginOutController : Controller
    {
        private IUserAppService _userAppService;
        public LoginOutController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            //记录Session
            HttpContext.Session.Clear();

            //HttpContext.Session.Set("CurrentUser", null);
            //跳转到系统首页
            return RedirectToAction("Index", "Login");
             
        }
    }
}
