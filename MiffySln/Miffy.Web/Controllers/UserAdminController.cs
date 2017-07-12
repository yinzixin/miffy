using Miffy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Miffy.Web.Common;

namespace Miffy.Web.Controllers
{
    public class UserAdminController : BaseController
    {

        // GET: UserAdmin
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            var user = UserService.Login(model.User, model.Password);

            //var log = new LoginLog
            //{
            //    CreateTime = DateTime.Now,
            //    IDUser = user == null ? -1 : user.ID,
            //    LoginName = model.User,
            //    IsPass = (user != null),
            //    IP = GetIP()
            //};


            //UserService.Log(log);

            if (user != null)
            {
                this.SetCurrentUser(user);
                return RedirectToAction("Index", "UserAdmin");
            }
            else
            {
                ModelState.AddModelError("msg", "用户名或密码不正确.");
                return View(model);
            }
        }
    }



    public class LoginModel
    {
        public string User { get; set; }

        public string Password { get; set; }
    }
}