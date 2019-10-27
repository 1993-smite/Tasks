using System;
using Xunit;
using WebCoreMVC.Models;

namespace Tests
{
    public class FilmTest
    {
        [Fact]
        public void NewFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1" };
            Assert.Equal(film.Id, id);
        }

        [Fact]
        public void NewToCanselFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1", State= new New() };
            film.State = film.State.toCansel();
            var state = film.State as Cansel;
            Assert.NotEqual(state, null);
        }

        [Fact]
        public void NewToInWorkFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1", State = new New() };
            film.State = film.State.toInWork();
            var state = film.State as InWork;
            Assert.NotEqual(state, null);
        }

        [Fact]
        public void InWorkToDoneFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1", State = new InWork() };
            film.State = film.State.toDone();
            var state = film.State as Done;
            Assert.NotEqual(state, null);
        }

        [Fact]
        public void InWorkToCloseFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1", State = new InWork() };
            film.State = film.State.toClose();
            Assert.Equal(film.State, null);
        }

        [Fact]
        public void DoneToCloseFilmTest()
        {
            int id = 1;
            Film film = new Film() { Id = id, Name = "Test 1", State = new Done() };
            film.State = film.State.toClose();
            var state = film.State as Close;
            Assert.NotEqual(state,null);
        }
    }
}
