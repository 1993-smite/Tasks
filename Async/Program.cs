using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public static class Extension
    {
        public static int Count()
        {
            int res = 0;
            for(int i = 0; i < 100; i++)
            {
                res += i;
            }
            return res;
        }

        public async static void GetItem()
        {
            var rer = await Task.Run(()=>Extension.Count());
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Extension.GetItem();
        }
    }
}
