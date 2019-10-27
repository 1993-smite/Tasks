using System;
using System.Collections.Generic;
using WebCoreMVC.Models;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.Datas
{
    public static class FilmFactoryDatas
    {
        public static IEnumerable<Film> GetFilms(int fromIndex = 1, int count = 100, string filter = "")
        {
            for (int i = fromIndex; i < fromIndex + count; i++)
            {
                yield return new Film() { Id = i, Name = $"Film {filter} {i} {DateTime.Now:HH:mm}", State = new New() };
            }
        }
    }
}
