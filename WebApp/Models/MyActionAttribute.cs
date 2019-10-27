using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp.Models
{
    public class MyActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("Действие выполнено");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isInternal = bool.Parse(ConfigurationManager.AppSettings["isInternal"]);
            if (!isInternal)
                filterContext.Result =
                    new RedirectToRouteResult(
                           new RouteValueDictionary
                                {
                                    { "controller", "Home" },
                                    { "action", "Index" }
                                });
        }
    }
}