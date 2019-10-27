using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPool
{
    public class Network
    {
        public readonly int init;
        public readonly int h;
        public List<int> indexes = new List<int>();
        public Network(int _init, int _h)
        {
            init = _init;
            h = _h;
        }
    }

    class Program
    {
        static int N = 1000;

        int[] mass = new int[N];

        static int index = N;

        static void Iterate(Network net)
        {
            for(int i=net.init; i<=N && i>=0; i += net.h)
            {
                net.indexes.Add(i);
                //Console.WriteLine("{0} {1}",net.h > 0 ? new string(' ', 10) : "",i);
                if (net.h < 0)
                    index = i;
                else if (net.h > 0 && i >= index)
                    return;
                Thread.Sleep(4);
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Begin");
            var downIndex = new Network(N, -1);
            Thread thread = new Thread(()=>Iterate(downIndex));
            thread.IsBackground = false;
            thread.Start();

            var upIndex = new Network(0, 1);
            Iterate(upIndex);
            thread.Abort();
            for (int i = 0; i < upIndex.indexes.Count; i++)
                Console.WriteLine(upIndex.indexes[i]);
            for (int i = 0; i < downIndex.indexes.Count; i++)
                Console.WriteLine("",new string(' ',10),downIndex.indexes[i]);
            Console.ReadLine();
        }
    }
}
