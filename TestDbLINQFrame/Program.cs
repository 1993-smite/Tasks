using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testContext;

namespace TestDbLINQFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new testDataContext();
            var datas = from d in db.cities select d;

            foreach(var item in datas)
            {
                Console.WriteLine($"{item.id} \t {item.name}");
            }

            Console.ReadLine();
        }
    }
}
