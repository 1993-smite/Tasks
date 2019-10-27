using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMVC.Models;
using WebCoreMVC.Datas;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreMVC.Controllers
{
    public class OrderUserFilmController : Controller
    {
        public IActionResult Index()
        {
            return View(OrderUserFilmFactoryDatas.GetOrderUserFilms());
        }
    }
}