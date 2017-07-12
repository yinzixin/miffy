using Miffy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Miffy.Web.Common
{
    public class BaseController : Controller
    {
        public User GetUser()
        {
            return (User)Session["current_user"];
            // return new User { ID = 1, DefaultArea = "无锡" };
        }

        public void SetCurrentUser(User user)
        {
            Session["current_user"] = user;
        }
    }
}