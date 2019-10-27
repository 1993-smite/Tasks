using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCoreMVC.Datas;

namespace WebCoreMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View(UserFactoryDatas.GetUsers(1,40));
        }

        [HttpPost]
        public IActionResult GetUsers(int fromIndex, string filter)
        {
            var userList = UserFactoryDatas.GetUsers(fromIndex, 30, filter);
            return PartialView("UserList",userList);
        }

        [HttpPost]
        public IActionResult GetUser(int id)
        {
            var user = UserFactoryDatas.GetUser(id);
            return Json(user);
        }

        public IActionResult UpdateUser(int Id)
        {
            return View();
        }
    }
}