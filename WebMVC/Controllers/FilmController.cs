using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCoreMVC.Models;

namespace WebCoreMVC.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Card(int id)
        {
            Film film = new Film()
            {
                Id = id,
                Name = $"Film {id}",
                State = new New()
            };
            return View(film);
        }
    }
}