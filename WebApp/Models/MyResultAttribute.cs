﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class MyResultAttribute : FilterAttribute, IResultFilter
    {

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

            filterContext.HttpContext.Response.Write("Время текущего запроса HTTP: " + filterContext.HttpContext.Timestamp);
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var rrr = 5;
        }
    }
}