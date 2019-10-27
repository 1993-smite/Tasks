using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMVC.Models;

namespace WebCoreMVC.Datas
{
    public static class OrderUserFilmFactoryDatas
    {
        private static int MaxCount = 100;
        private static IEnumerable<OrderUserFilm> _getOrderUserFilms()
        {
            var users = UserFactoryDatas.GetUsers(1, 100);
            var films = FilmFactoryDatas.GetFilms(1, 100);
            for(int i = 1; i < MaxCount; i++)
            {
                yield return new OrderUserFilm() { Id=i
                    , Name=$"Order {i} {DateTime.Now:hh:mm}"
                    , Film=films.FirstOrDefault(x=>x.Id == i)
                    , User=users.FirstOrDefault(x=>x.Id == i) };
            }
        }

        public static IEnumerable<OrderUserFilm> GetOrderUserFilms()
        {
            return _getOrderUserFilms();
        }
    }
}
