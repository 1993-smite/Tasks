using System;
using testContext;
using System.Linq;

namespace TestDbLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new testDataContext();
            var datas = from d in db.cities select d;

            Console.WriteLine("Hello World!");
        }
    }
}
