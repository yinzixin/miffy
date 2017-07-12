using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Miffy.Model;
using Miffy.Data;

namespace Miffy.Web.Common
{
    public class UserProfileFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var user = (User)filterContext.HttpContext.Session["current_user"];
            if (user != null)
            {
                filterContext.Controller.ViewBag.User = user;
            }
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {

        }
    }

    public class DomainTranslateAttribute : AuthorizeAttribute
    {
         
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var host = httpContext.Request.Url.Host;
            User user = tryGetUser(host);

            if (user==null)
            {
                return false;
            }
            else
            {
                httpContext.Session["user_page"] = user;
                return true;
            }
        }

        private User tryGetUser(string host)
        {
            if (HttpContext.Current.Session["user_page"] != null)
            {
                return (User)HttpContext.Current.Session["user_page"];
            }

            var user= UserService.GetByDomain(host);
            if (user != null)
            {
                HttpContext.Current.Session["user_page"] = user;
              //  HttpContext.Current.Request.RequestContext.HttpContext.co
            }

            return user;
        }
    }
}