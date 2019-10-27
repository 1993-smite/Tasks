using NUnit.Framework;
using WebCoreMVC.Models;

namespace Tests
{
    public class FilmTest
    {
        public void NewFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1" };
            Assert.Equals(film.Id,1);
        }
    }
}