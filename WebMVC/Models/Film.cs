using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebCoreMVC.Models
{
    public class Film
    {
        public int Id;
        public string Name;
        public FilmState State;
    }

    public abstract class FilmState
    {
        public readonly int code = 0;
        public virtual FilmState toNew() => null;
        public virtual FilmState toCansel() => null;
        public virtual FilmState toInWork() => null;
        public virtual FilmState toDone() => null;
        public virtual FilmState toClose() => null;
    }

    public class New : FilmState
    {
        public readonly int code = 1;
        public override FilmState toInWork() => new InWork();
        public override FilmState toCansel() => new Cansel();
    }

    public class Cansel : FilmState { public readonly int code = 9; }

    public class InWork : FilmState
    {
        public readonly int code = 2;
        public override FilmState toCansel() => new Cansel();
        public override FilmState toDone() => new Done();
    }

    public class Done : FilmState
    {
        public static readonly int code = 4;
        public override FilmState toClose() => new Close();
    }

    public class Close : FilmState { public static int code => 5; }

    public static class FilmStateFactory
    {
        public static string GetFilmStateName(Film film)
        {
            string filmStateName = string.Empty;
            /*switch (film.State)
            {
                case New.code:
                    filmStateName = "Новый";
                    break;
                case Cansel:
                    filmStateName = "Отменен";
                    break;
                case InWork:
                    filmStateName = "В работе";
                    break;
                case Done:
                    filmStateName = "Завершен";
                    break;
                case Close:
                    filmStateName = "Закрыт";
                    break;
                default:
                    filmStateName = "Неизвестен";
            }*/
            return filmStateName;
        }
    }
}
